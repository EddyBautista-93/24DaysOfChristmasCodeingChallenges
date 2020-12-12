using System;
using System.Collections.Generic;
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
        //   public static int Solve(string s)
        //   {
        //       char[] nonConsonantArray = { 'a', 'e', 'i', 'o', 'u' };
        //       char[] inputStringArray = s.ToArray();
        //       var newWord = new StringBuilder();
        //       int numberSum = 0;
        //       int largestNumber = 0;
        //
        //
        //       foreach (char c in inputStringArray)
        //       {
        //           int index = ((int)char.ToUpper(c) - 64);
        //           if (!nonConsonantArray.Contains(c))
        //           {
        //               newWord.Append(c);
        //               numberSum += index;
        //               if (numberSum > largestNumber)
        //               {
        //                   largestNumber = numberSum;
        //               }
        //           }
        //           else if (nonConsonantArray.Contains(c))
        //           {
        //               newWord.Clear();
        //               numberSum = 0;
        //           }
        //       }
        //       return largestNumber;
        //   }
        //   //shorter way to do it from codewar forums
        //   //  private static readonly char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
        //
        //   public static int SolveCodeWars(string input)
        //   {
        //       char[] Vowels = { 'a', 'e', 'i', 'o', 'u' };
        //
        //       return input.ToLowerInvariant()
        //             .Split(Vowels, StringSplitOptions.RemoveEmptyEntries)
        //             .Max(s => s.Sum(c => c - 'a' + 1));
        //   }

        //Day 2 Predict Age

        //My grandfather always predicted how old people would get, and right before he passed away he revealed his secret!
        //
        //In honor of my grandfather's memory we will write a function using his formula!
        //
        //Take a list of ages when each of your great-grandparent died.
        //Multiply each number by itself.
        //Add them all together.
        //Take the square root of the result.
        //Divide by two.


        //public static int PredictAge(params int[] ages)
        //{
        //
        //return (int)Math.Sqrt(ages.Sum(x => x * x)) / 2;
        //}

        //Day 3 - Disemvowel Trolls

        //Trolls are attacking your comment section!
        //
        //A common way to deal with this situation is to remove all of the vowels from the trolls' comments, neutralizing the threat.
        //
        //Your task is to write a function that takes a string and return a new string with all vowels removed.
        //
        //For example, the string "This website is for losers LOL!" would become "Ths wbst s fr lsrs LL!".

        //public static string Disemvowel(string str)
        //{       
        //    string vowels = "aeiouAEIOU";
        //    return new String(str.Where(c => !vowels.Contains(c)).ToArray());        
        //}

        // Day 4 - Encrypt this!

        //Encrypt this!
        //
        //You want to create secret messages which can be deciphered by the Decipher this! kata.Here are the conditions:
        //
        //Your message is a string containing space separated words.
        //You need to encrypt each word in the message using the following rules:
        //The first letter needs to be converted to its ASCII code.
        //The second letter needs to be switched with the last letter
        //Keepin' it simple: There are no special characters in input.

        //Kata.EncryptThis("Hello") == "72olle"
        //Kata.EncryptThis("good") == "103doo"
        //Kata.EncryptThis("hello world") == "104olle 119drlo"

        // since we are encryptiing sentences it will be better to build a seprate tool to convert a word
        // to the way its asked.
        //public static string EncryptWord(string word)
        //{
        //    char[] charWordArray = word.ToArray();
        //
        //    // return the asscii code for a single char
        //    if (charWordArray.Length == 1)
        //    {
        //        char onlyLetter = charWordArray[0];
        //        int ASCIICodeValueOfNumberChar = (int)onlyLetter;
        //        string ASCIILetter = ASCIICodeValueOfNumberChar.ToString();
        //        return ASCIILetter;
        //
        //
        //    } // if empty return string empty
        //    else if(word == "")
        //    {
        //        return string.Empty;
        //    }
        //    // take the 3 main elements we will be working with 
        //    char firstLetter = charWordArray[0];
        //    char secondLetter = charWordArray[1];
        //    char lastLetter = charWordArray[charWordArray.Length - 1];
        //    
        //    // convert first word to Ascii
        //    int ASCIICodeValueOfNumber = (int)firstLetter;
        //    string ASCIIStringed = ASCIICodeValueOfNumber.ToString();
        //    // swap the second and last letter then add the new 1st indez = ascii code. 
        //    charWordArray[1] = lastLetter;
        //    charWordArray[charWordArray.Length - 1] = secondLetter;
        //    string stringCharWordArray = new string(charWordArray);
        //    string encryptedWord = stringCharWordArray.Remove(0, 1).Insert(0, ASCIIStringed);
        //    return encryptedWord;
        //}
        //
        //// using the tool we created above we are able to create a turn the string into a array and loop through it changing each word to the encryped vers then add it to a new array to convert to a string sentence.
        //public static string EncryptThis(string input)
        //{     
        //    string encyrptedInput;
        //    int i = 0;
        //    string[] inputArray = input.Split();
        //    string[] encryptedArray = new string[inputArray.Length];
        //
        //
        //    foreach (string x in inputArray)
        //    {
        //        string encryptedWord = EncryptWord(x);
        //        encryptedArray[i] = encryptedWord;
        //        i++;
        //    }
        //    encyrptedInput = string.Join(" ", encryptedArray);
        //    Console.WriteLine(encyrptedInput);
        //    return encyrptedInput;
        //}

        //test cases 
        // [TestCase("", "")]
        // [TestCase("A", "65")]
        // [TestCase("Ab", "65b")]
        // [TestCase("Abc", "65cb")]
        // [TestCase("Abcd", "65dcb")]
        // [TestCase("A wise old owl lived in an oak", "65 119esi 111dl 111lw 108dvei 105n 97n 111ka")]
        // [TestCase("The more he saw the less he spoke", "84eh 109ero 104e 115wa 116eh 108sse 104e 115eokp")]
        // [TestCase("The less he spoke the more he heard", "84eh 108sse 104e 115eokp 116eh 109ero 104e 104dare")]
        // [TestCase("Why can we not all be like that wise old bird", "87yh 99na 119e 110to 97ll 98e 108eki 116tah 119esi 111dl 98dri")]
        // [TestCase("Thank you Piotr for all your help", "84kanh 121uo 80roti 102ro 97ll 121ruo 104ple")]

        //Day 5 - Count characters in your string

        //The main idea is to count all the occurring characters in a string. If you have a string like aba, then the result should be {'a': 2, 'b': 1}.

        //What if the string is empty? Then the result should be empty object literal, {}.

        //public static Dictionary<char, int> Count(string str)
        //{
        //    return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        //}

        // Day 5 longest_palindrome

        // Longest Palindrome
        // 
        // Find the length of the longest substring in the given string s that is the same in reverse.
        // 
        // As an example, if the input was “I like racecars that go fast”, the substring(racecar) length would be 7.
        // 
        // If the length of the input string is 0, the return value must be 0.
        // 
        // Example:
        // "a" -> 1 
        // "aab" -> 2  
        // "abcde" -> 1
        // "zzbaabcd" -> 4
        // "" -> 0

        // first we want to check if the string is palindrome so we create a tool method
        //public static bool IsPalindrome(string str)
        //{
        //    var arr = str.ToCharArray();
        //    Array.Reverse(arr);
        //    var reversed = new string(arr);
        //    return str == reversed;
        //}
        //
        //public static int GetLongestPalindrome(string str)
        //{
        //    if (str == null) return 0;
        //
        //    int max = 0;
        //    for (int i = 0; i < str.Length; ++i)
        //        for (int j = i; j < str.Length; ++j)
        //            if (IsPalindrome(str.Substring(i, j - i + 1)))
        //                max = Math.Max(max, j - i + 1);
        //
        //    return max;
        //}
        //


        // Day 6 Count the smiley faces!

        // Given an array(arr) as an argument complete the function countSmileys that should return the total number of smiling faces.
        // 
        // Rules for a smiling face:
        // 
        // 
        // Each smiley face must contain a valid pair of eyes. Eyes can be marked as : or ;
        //         A smiley face can have a nose but it does not have to.Valid characters for a nose are - or ~
        //        Every smiling face must have a smiling mouth that should be marked with either ) or D
        // No additional characters are allowed except for those mentioned.
        // 
        // Valid smiley face examples: :) :D ;-D :~)
        // Invalid smiley faces: ;( :> :} :]

        //Example
        //countSmileys([':)', ';(', ';}', ':-D']);       // should return 2;
        //countSmileys([';D', ':-(', ':-)', ';~)']);     // should return 3;
        //countSmileys([';]', ':[', ';*', ':$', ';-D']); // should return 1;

        // Day 7 - Maximum Length Difference

        // You are given two arrays a1 and a2 of strings.Each string is composed with letters from a to z.Let x be any string in the first array and y be any string in the second array.
        // 
        // Find max(abs(length(x) − length(y)))
        // 
        // If a1 and/or a2 are empty return -1 in each language except in Haskell(F#) where you will return Nothing (None).
        // 
        // Example:
        // a1 = ["hoqq", "bbllkw", "oox", "ejjuyyy", "plmiis", "xxxzgpsssa", "xxwwkktt", "znnnnfqknaz", "qqquuhii", "dvvvwz"]
        // a2 = ["cccooommaaqqoxii", "gggqaffhhh", "tttoowwwmmww"]
        // mxdiflg(a1, a2) --> 13

        public static int Mxdiflg(string[] a1, string[] a2)
        {
            if (a1.Length <= 0 || a2.Length <= 0)
                return -1;
            var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
            var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
            return Math.Max(first, second);
        }
    }


    private static void Main(string[] args)
            {     
           
            }
        
    }
}
