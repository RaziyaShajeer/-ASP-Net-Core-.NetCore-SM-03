using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserAlreadyExist_Exception.Exception
{
    internal class EmailAlreadyExistsException:ApplicationException
    {
        public EmailAlreadyExistsException() { }

        public EmailAlreadyExistsException(string message) : base(message) { }
    }
}
