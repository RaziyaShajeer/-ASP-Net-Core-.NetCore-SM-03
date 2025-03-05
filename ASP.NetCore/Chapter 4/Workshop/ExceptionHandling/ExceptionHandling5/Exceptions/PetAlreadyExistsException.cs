using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling5.Exceptions
{
    internal class PetAlreadyExistsException:Exception
    {
        public PetAlreadyExistsException() { }
        public PetAlreadyExistsException(string message) 
            : base(string.Format("Pet Already Exists",message)) { }

    }
}
