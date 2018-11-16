using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace P3WordsCount
{
    class WordsCount
    {
        static Dictionary<string, int> wordsCounter = new Dictionary<string, int>();

        static void Main(string[] args)
        {
            string wordsFilePath = Path.Combine("../../../", "words.txt");
            string textFilePath = Path.Combine("../../../", "text.txt");
            string resultFilePath = Path.Combine("../../../", "result.txt");
            List<string> searchWords = new List<string>();
            List<string> allWords = new List<string>();
            

            using (var streamReader = new StreamReader(wordsFilePath))
            {
                searchWords = streamReader.ReadToEnd().Split(System.Environment.NewLine, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
            using (var streamReader = new StreamReader(textFilePath))
            {
                string recordText = streamReader.ReadToEnd();
                allWords = Regex.Split(recordText, @"\W", RegexOptions.Multiline).ToList();
                allWords = allWords.FindAll(x => x != "");
            }

            using (var streamWriter = new StreamWriter(resultFilePath))
            {
                MatchWords(searchWords, allWords);

                if (wordsCounter.Count > 0)
                {
                    foreach (var word in wordsCounter.OrderByDescending(x => x.Value))
                    {
                        streamWriter.WriteLine($"{word.Key} - {word.Value}");
                    }
                }
            }
            
        }

        private static void MatchWords(List<string> searchWords, List<string> allWords)
        {
            foreach (var searchedItem in searchWords)
            {
                foreach (var word in allWords)
                {
                    if (word.ToLower() == searchedItem.ToLower())
                    {
                        if (!wordsCounter.ContainsKey(searchedItem))
                        {
                            wordsCounter.Add(searchedItem, 1);
                        }
                        else
                        {
                            wordsCounter[searchedItem]++;
                        }
                    }
                }
            }
        }
    }
}
