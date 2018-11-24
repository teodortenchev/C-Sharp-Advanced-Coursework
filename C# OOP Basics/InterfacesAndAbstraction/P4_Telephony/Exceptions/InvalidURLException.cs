using System;

namespace P4_Telephony
{
    
    public class InvalidURLException : FormatException
    {
       public InvalidURLException(string message = "Invalid URL!") : base(message)
        {
        }
    }
}