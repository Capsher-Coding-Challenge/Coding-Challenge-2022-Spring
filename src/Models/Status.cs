namespace IntegrationManager.Models
{
	public enum StatusCode
	{
		Offline,
		Running,
		Warning,
		Error
	}

	public class Status
	{
		public StatusCode StatusCode { get; set;}

		public string Message { get; set;}
	}
}
