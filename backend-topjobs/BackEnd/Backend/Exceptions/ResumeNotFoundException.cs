using System;
using System.Collections.Generic;
using System.Text;
namespace Exceptions
{
    public class ResumeNotFoundException : ApplicationException
    {
        public ResumeNotFoundException() { }
        public ResumeNotFoundException(string message) : base(message) {
            message = "this resume not exist";
        }  
    }
}
