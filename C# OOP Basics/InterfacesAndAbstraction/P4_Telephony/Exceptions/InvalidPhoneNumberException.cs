using System;
using System.Collections.Generic;
using System.Text;

namespace P4_Telephony
{
    public class InvalidPhoneNumberException : FormatException
    {
        public InvalidPhoneNumberException(string message = "Invalid number!") : base(message)
        {

        }
    }
}
