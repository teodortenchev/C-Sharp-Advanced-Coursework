using System;
using System.Linq;

namespace P4_Telephony
{
    public class Smartphone : ICalls, IBrowse
    {
        public void Call(string number)
        {
            if (number.Any(x => !char.IsDigit(x)))
            {
                throw new InvalidPhoneNumberException();
            }

            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            if (url.Any(x => char.IsDigit(x)))
            {
                throw new InvalidURLException();
            }

            Console.WriteLine($"Browsing: {url}!");
        }

    }
}
