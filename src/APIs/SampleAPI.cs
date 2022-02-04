using System.Threading.Tasks;

namespace IntegrationManager.APIs
{
	public class SampleAPI : ISampleAPI
	{
		public async Task<EndpointStatus> GetStatusDetails()
		{
			//TODO: Put actual connection and request logic here
			return null;
		}
	}
}
