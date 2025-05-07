using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace txt_reader
{
    internal class Reader
    {
        public void ReadFile(string filePath)
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            int wordsCounter = 0;
            int charCounter = 0;
            int vowelsCounter = 0;
            int consonantsCounter = 0;

            foreach (string line in lines)
            {
                wordsCounter += CountWords(line);
                charCounter += line.Length;
                vowelsCounter += CountOccurencies(line, true);
                consonantsCounter += CountOccurencies(line, false);
                Console.WriteLine(line);
            }

            Console.WriteLine(@$"
Words: {wordsCounter}
Char: {charCounter}
Vowels: {vowelsCounter}
Consonants: {consonantsCounter}");

        }

        private int CountWords(string line)
        {
            string[] words = line.Split(" ");
            
            return words.Length;
        }

        private int CountOccurencies(string line, bool searchForVowels)
        {
            string pattern;

            if (searchForVowels)
            {
                pattern = "[aeiouAEIOU]";
            }
            else
            {
                pattern = "(?i)[b-df-hj-np-tv-z]";
            }

            return Regex.Matches(line, pattern).Count;
        }

        internal void FindArgOccurencies(string filePath, string s)
        {
            string[] lines = File.ReadAllLines(filePath);
            int counter = 0;

            foreach (string line in lines)
            {
                Console.WriteLine(line);
                if (line.Contains(s))
                {
                    counter++;
                }
            }

            Console.WriteLine($"the word '{s}' appears {counter} times in this text");
        }
    }
}
