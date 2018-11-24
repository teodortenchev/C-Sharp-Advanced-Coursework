using System;

namespace P4_Telephony
{
    public class Smartphone : ICalls, IBrowse
    {
        public void Call(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                if (!char.IsDigit(number[i]))
                {
                    throw new InvalidPhoneNumberException();
                }
            }

            Console.WriteLine($"Calling... {number}");
        }

        public void Browse(string url)
        {
            for (int i = 0; i < url.Length; i++)
            {
                if(char.IsDigit(url[i]))
                {
                    throw new InvalidURLException();
                }
            }

            Console.WriteLine($"Browsing: {url}!");
        }

    }
}
