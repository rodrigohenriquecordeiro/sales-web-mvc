using System;

namespace SalesWebMVC.Services.Excetions
{
    public class DbConcurrencyException: ApplicationException
    {
        public DbConcurrencyException(string message) : base(message)
        { 
        }
    }
}
