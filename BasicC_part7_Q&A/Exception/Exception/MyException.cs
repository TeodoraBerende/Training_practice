using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    public class MyException : Exception
    {
        private string _details;
        public MyException(string message, string details) : base(message)
        {
            _details = details;
        }

        public string GetDetails()
        {
            return _details;
        }
    }
}
