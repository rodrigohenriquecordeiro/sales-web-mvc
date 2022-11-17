using System;

namespace SalesWebMVC.Services.Excetions
{
    public class NotFoundExcetions : ApplicationException
    {
        public NotFoundExcetions(string message) : base(message)
        { 
        }
    }
}
