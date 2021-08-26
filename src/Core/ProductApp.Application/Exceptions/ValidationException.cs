using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException() : this("Validation error")
        {

        }

        public ValidationException(string Message) : base(Message)
        {

        }

        public ValidationException(Exception ex) : this(ex.Message )
        {

        }
    }
}
