using System;

namespace Anagram.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 2 || args.Length > 3)
            {
                PrintUsage();
                return;
            }

            bool ignoreCase = false;

            if (args.Length == 3 && !bool.TryParse(args[2], out ignoreCase))
            {
                PrintUsage();
                return;
            }

            var anagramChecker = new WordFun.Utilities.Anagram(ignoreCase);

            var isAnagram = false;

            try
            {
                isAnagram = anagramChecker.AreAnagrams(args[0], args[1]);
            }
            catch (Exception e)
            {
                System.Console.Write($"Whoops, theres a problem: {e.Message}");
                return;
            }

            string msg = String.Format("{0} and {1} {2} anagrams with case sensitivity {3}", args[0], args[1], isAnagram ? "are" : "are NOT", ignoreCase ? "OFF": "ON");

            System.Console.WriteLine(msg);

            Environment.ExitCode = isAnagram ? 1 : 0;

            return;

        }

        static void PrintUsage()
        {
            System.Console.WriteLine("Usage: Anagram.Console <string> <string> {ignoreCase: bool} ");
            Environment.ExitCode = -1;
        }
    }
}
