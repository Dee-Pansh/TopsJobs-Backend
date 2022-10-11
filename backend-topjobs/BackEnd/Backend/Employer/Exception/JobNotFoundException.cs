using System;
using System.Collections.Generic;
using System.Text;
namespace Exceptions
{
    public class JobNotFoundException : ApplicationException
    {
        public JobNotFoundException() { }
        public JobNotFoundException(string message) : base(message) {
            message = "this job not exist";
                }
    }
}
