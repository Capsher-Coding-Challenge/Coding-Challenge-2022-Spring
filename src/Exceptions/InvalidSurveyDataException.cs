using System;
namespace IntegrationManager.Exceptions
{
    public class InvalidSurveyDataException : Exception
    {
        public InvalidSurveyDataException(string reason) : base($"Invalid Survey Data: {reason}")
        {
        }
    }
}
