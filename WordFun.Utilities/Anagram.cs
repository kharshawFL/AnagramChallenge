using System;
using System.Text.RegularExpressions;

namespace WordFun.Utilities
{
    public class Anagram : IAnagram
    {
        private bool _ignoreCase;


        public Anagram()
        {
            _ignoreCase = false;
        }

        public Anagram(bool ignoreCase)
        {
            _ignoreCase = ignoreCase;
        }

        private string AlphabetizeString(string input)
        {
            var arr = input.ToCharArray();
            Array.Sort(arr);

            return new string(arr);
        }

        private bool VerifyAlphanumeric(string input)
        {
            var regex = new Regex(@"^[a-zA-Z0-9\s]*$");

            return regex.IsMatch(input);
        }


        public bool AreAnagrams(string firstWord, string secondWord)
        {
            if (firstWord == null || secondWord == null)
            {
                throw new ArgumentNullException("strings must not be null");
            }

            if (!VerifyAlphanumeric(firstWord) || !VerifyAlphanumeric(secondWord))
            {
                throw new ArgumentException("strings must be alphanumeric");
            }

            if (_ignoreCase)
            {
                firstWord = firstWord.ToUpper();
                secondWord = secondWord.ToUpper();
            }

            return AlphabetizeString(firstWord) == AlphabetizeString(secondWord);
        }
    }
}
