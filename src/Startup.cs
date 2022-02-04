using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using Swashbuckle.AspNetCore.SwaggerGen;
using IntegrationManager.Managers;
using IntegrationManager.APIs;
using Hangfire;
using Hangfire.MemoryStorage;

namespace IntegrationManager
{
	public class Startup
	{
		private IWebHostEnvironment _hostingEnvironment;

		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		private static IEnumerable<(string name, string title, string version)> GetAPIDefinitions()
		{
			yield return ("v1", "Integration Manager API", "v1");
		}

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();

			SchemaGeneratorOptions generatorOptions = null;

			services.AddSwaggerGen(c =>
			{
				foreach (var d in GetAPIDefinitions())
				{
					c.SwaggerDoc(d.name, new Microsoft.OpenApi.Models.OpenApiInfo { Title = d.title, Version = d.version });
				}

				
				var defaultSelector = c.SchemaGeneratorOptions.SchemaIdSelector;
				c.CustomSchemaIds(x => defaultSelector(x));

				generatorOptions = c.SchemaGeneratorOptions;
			});

			services.AddTransient<SchemaGeneratorOptions>(x => generatorOptions);

			services.AddTransient<IRecurringIntegrationManager, RecurringIntegrationManager>();
			services.AddTransient<ISampleAPI, SampleAPI>();

			// Needed in swagger rc5 or when 5.0 is released
			// until this moves to dotnet core 3.0 or later
			services.AddSwaggerGenNewtonsoftSupport();

			services.AddHangfire(h => h.UseMemoryStorage());
			services.AddHangfireServer();

			// Framework Services
			services.AddMemoryCache();

			// App Services - since these are lightweight and stateless, they'll be transient
			services.AddTransient<IRecurringIntegrationManager, RecurringIntegrationManager>();
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			_hostingEnvironment = env;

			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseHsts();
				app.UseHttpsRedirection();
			}

			app.UseSwagger(c =>
			{
				c.RouteTemplate = "swagger/{documentName}";
			});

			app.UseSwaggerUI(c =>
			{
				c.RoutePrefix = "swagger";

				foreach (var d in GetAPIDefinitions())
				{
					c.SwaggerEndpoint($"/swagger/{d.name}", $"{d.title} {d.version}");
				}
			});

			app.UseStaticFiles();

			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				//endpoints.MapHealthChecks("/health");
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
			});


			using (var scope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
			{
				var integrationManager = scope.ServiceProvider.GetRequiredService<IRecurringIntegrationManager>();
				integrationManager.Initialize();
			}
		}
	}
}
