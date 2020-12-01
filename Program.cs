using System;
using System.Linq;
using System.Text;

namespace _24DaysOfChristmasCodeingChallenges
{
    class Program
    {
        //Consonant value

        //Given a lowercase string that has alphabetic characters only and no spaces, return the highest value of consonant substrings.Consonants are any letters of the alphabet except "aeiou".
        //
        //We shall assign the following values: a = 1, b = 2, c = 3, .... z = 26.
        //
        //For example, for the word "zodiacs", let's cross out the vowels. We get: "z o d ia cs"
        //
        //-- The consonant substrings are: "z", "d" and "cs" and the values are z = 26, d = 4 and cs = 3 + 19 = 22.The highest is 26.
        //solve("zodiacs") = 26
        //
        //For the word "strength", solve("strength") = 57
        //-- The consonant substrings are: "str" and "ngth" with values "str" = 19 + 20 + 18 = 57 and "ngth" = 14 + 7 + 20 + 8 = 49. The highest is 57.S
        public static int Solve(string s)
        {
            char[] nonConsonantArray = { 'a', 'e', 'i', 'o', 'u' };
            char[] inputStringArray = s.ToArray();
            var newWord = new StringBuilder();
            int numberSum = 0;
            int largestNumber = 0;


            foreach (char c in inputStringArray)
            {
                int index = ((int)char.ToUpper(c) - 64);
                if (!nonConsonantArray.Contains(c))
                {
                    newWord.Append(c);
                    numberSum += index;
                    if (numberSum > largestNumber)
                    {
                        largestNumber = numberSum;
                    }
                }
                else if (nonConsonantArray.Contains(c))
                {
                    newWord.Clear();
                    numberSum = 0;
                }
            }
            return largestNumber;
        }
        //shorter way to do it from codewar forums
        //  private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static int SolveCodeWars(string input)
        {
            char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };

            return input.ToLowerInvariant()
                  .Split(Vowels, StringSplitOptions.RemoveEmptyEntries)
                  .Max(s => s.Sum(c => c - 'a' + 1));
        }

        private static void Main(string[] args)
        {
            //  Solve("Zodiac");
            Solve("chruschtschov");

        }
    }
}
