using System;
namespace IntegrationManager.Exceptions
{
    public class EntryNotFoundException : Exception
    {
        public EntryNotFoundException(Guid id) : base($"No entry found with ID {id}.")
        {
        }
    }
}
