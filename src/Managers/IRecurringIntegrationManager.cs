using IntegrationManager.Models;
using System.Threading.Tasks;

namespace IntegrationManager.Managers
{
	public interface IRecurringIntegrationManager
	{
		/// <summary>
		/// TODO: Describe what this does
		/// Use /// to setup documentation on function headers
		/// </summary>
		public void Initialize();

		public Task RecurringIntegrationJob();

		public Status GetStatus();
	}
}
