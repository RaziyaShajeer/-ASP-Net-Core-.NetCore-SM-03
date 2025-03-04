using EmailValidation.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailValidation
{
    internal class EmailValidator
    {
        public static void ValidateEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$"; // Simple email pattern
            if (!Regex.IsMatch(email, pattern))
            {
                throw new InvalidEmailException($"Invalid email address: {email}");
            }
        }
    }
}
