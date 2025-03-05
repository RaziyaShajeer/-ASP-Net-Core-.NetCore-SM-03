using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAlreadyExist_Exception.Exception
{
    internal class AgeException:ApplicationException
    {
        public AgeException() { }

        public AgeException(string message) : base(message) { }
    }
}
