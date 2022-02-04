using Hangfire;
using IntegrationManager.APIs;
using IntegrationManager.Models;
using System.Threading.Tasks;

namespace IntegrationManager.Managers
{
	public class RecurringIntegrationManager : IRecurringIntegrationManager
	{
		private readonly ISampleAPI _sampleAPI;
		private Status _status;

		public RecurringIntegrationManager(
			ISampleAPI sampleAPI)
		{
			_sampleAPI = sampleAPI;
			_status = new Status
			{
				StatusCode = StatusCode.Offline
			};
		}

		public void Initialize()
		{
			// TODO: Set up connection and initialize recurring jobs

			RecurringJob.AddOrUpdate<RecurringIntegrationManager>(e => e.RecurringIntegrationJob(), Cron.Hourly);
		}

		public async Task RecurringIntegrationJob()
		{
			// TODO: Actually perform the recurring background job
		}

		public Status GetStatus()
		{
			return _status;
		}
	}
}
