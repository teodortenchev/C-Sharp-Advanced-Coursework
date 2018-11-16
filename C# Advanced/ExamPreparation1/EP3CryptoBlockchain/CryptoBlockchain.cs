using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace EP3CryptoBlockchain
{
    class CryptoBlockchain
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            string code = string.Empty;
            

            for (int i = 0; i < lines; i++)
            {
                code += Console.ReadLine();
            }

            string pattern = @"{[^\[\]{]+}|\[[^{\[\]}]+]";

            MatchCollection matches = Regex.Matches(code, pattern);
            //List<string> validNumberStrings = new List<string>();

            foreach (var match in matches)
            {
                pattern = @"[0-9]+";
                Match numMatch = Regex.Match(match.ToString(), pattern);
                string numMatchString = numMatch.ToString();
                pattern = @"[0-9]{3}";
                MatchCollection matchesNew = Regex.Matches(numMatchString, pattern);
                if(numMatchString.Length % 3 == 0)
                {
                    Decrypt(matchesNew,match.ToString().Length);
                }
            }

            Console.WriteLine();
        }

        private static void Decrypt(MatchCollection matchesNew, int cryptoLength)
        {
            foreach (var match in matchesNew)
            {
                string result = match.ToString();
                if (result.Substring(0) == "0")
                {
                    result.Remove(0,1);
                }
                int charNum = int.Parse(result) - cryptoLength;

                Console.Write((char)charNum);
            }
        }
    }
}
