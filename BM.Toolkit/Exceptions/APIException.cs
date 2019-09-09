using System;
namespace BM.Toolkit.Exceptions
{
    public class APIException : ApplicationException
    {
        public APIException(string message) : base(message)
        {
        }
    }
}
