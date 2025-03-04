using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation.Exception
{
    internal class InvalidEmailException : ApplicationException
    {
        public InvalidEmailException(string message) : base(message) { }
    }
}
