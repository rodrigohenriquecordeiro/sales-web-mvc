using System;

namespace SalesWebMVC.Services.Excetions
{
    public class IntegrityExcetion : ApplicationException
    {
        public IntegrityExcetion(string message) : base(message)
        { 
        }
    }
}
