using System;
using System.Threading.Tasks;

namespace IntegrationManager.APIs
{
    /// <summary>
    /// Endpoint representation of Status information
    /// </summary>
    public class EndpointStatus
    {
        public string EndpointSystemID { get; set; }
        public string RecordType { get; set; }
        public string StatusCode { get; set; }
    }

    /// <summary>
    /// A custom base class for known exceptions that arise from the connection
    /// </summary>
    public class EndpointException : Exception
    {
        public EndpointException()
        {
        }

        public EndpointException(string message) : base(message)
        {
        }

        public EndpointException(string message, Exception raw) : base(message, raw)
        {
        }

        /// <summary>
        /// The raw exception instance thrown by the interface
        /// </summary>
        public Exception RawException { get { return this.InnerException; } }
    }

    /// <summary>
    /// The system could not authorize with the endpoint. 
    /// </summary>
    public class EndpointAuthorizationException : EndpointException
    {
        public EndpointAuthorizationException()
        {
        }

        public EndpointAuthorizationException(string message) : base(message)
        {
        }

        public EndpointAuthorizationException(string message, Exception raw) : base(message, raw)
        {
        }
    }

    public interface ISampleAPI
    {
        /// <summary>
        /// Get the status of the endpoint
        /// </summary>
        /// <returns>Details about the endpoint. Null if no record found. Throws an exception on error.</returns>
        public Task<EndpointStatus> GetStatusDetails();
    }
}
