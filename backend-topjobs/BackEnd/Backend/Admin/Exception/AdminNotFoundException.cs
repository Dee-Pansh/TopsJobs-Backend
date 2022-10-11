using System;
using System.Collections.Generic;
using System.Text;
namespace Exception
{
    public class AdminNotFoundException : ApplicationException
    {
        public AdminNotFoundException() { }
        public AdminNotFoundException(string message):base(message) {
            message = "this admin details are not found";

        }
    }
}
