﻿namespace _24DaysOfChristmasCodeingChallenges
{
    internal class Program
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

        //     public static int Mxdiflg(string[] a1, string[] a2)
        //     {
        //         if (a1.Length <= 0 || a2.Length <= 0)
        //             return -1;
        //         var first = Math.Abs(a1.Max(x => x.Length) - a2.Min(x => x.Length));
        //         var second = Math.Abs(a2.Max(x => x.Length) - a1.Min(x => x.Length));
        //         return Math.Max(first, second);
        //     }
        // }

        // Day 8 Middle Character

        // You are going to be given a word.Your job is to return the middle character of the word. If the word's length is odd, return the middle character. If the word's length is even, return the middle 2 characters.
        //
        // #Examples:
        //
        // Kata.getMiddle("test") should return "es"
        //
        // Kata.getMiddle("testing") should return "t"
        //
        // Kata.getMiddle("middle") should return "dd"
        //
        // Kata.getMiddle("A") should return "A"

        // public static string GetMiddle(string s)
        // {
        //     if (string.IsNullOrEmpty(s) || s.Length == 0)
        //         return "";
        //
        //     if (s.Length % 2 == 0)
        //         return s.Substring((s.Length / 2) - 1, 2);
        //
        //     return s.Substring((s.Length / 2), 1);
        // }

        // Day 8 Sum of Triangular Numbers

        // Your task is to return the sum of Triangular Numbers up-to-and-including the nth Triangular Number.
        //
        // Triangular Number: "any of the series of numbers (1, 3, 6, 10, 15, etc.) obtained by continued summation of the natural numbers 1, 2, 3, 4, 5, etc."
        //
        // [01]
        // 02 [03]
        // 04 05 [06]
        // 07 08 09 [10]
        // 11 12 13 14 [15]
        // 16 17 18 19 20 [21]

        // public static int SumTriangularNumbers(int n)
        // {
        //     int sum = 0;
        //     for (int i = 1; i <= n; i++)
        //         sum += i * (i + 1) / 2;
        //     return sum;
        // }

        // Day 9 -Fix string case

        // In this Kata, you will be given a string that may have mixed uppercase and lowercase letters and your task is to convert that string to either lowercase only or uppercase only based on:
        //
        // make as few changes as possible.
        // if the string contains equal number of uppercase and lowercase letters, convert the string to lowercase.
        // For example:
        //
        // solve("coDe") = "code". Lowercase characters > uppercase. Change only the "D" to lowercase.
        // solve("CODe") = "CODE". Uppercase characters > lowecase.Change only the "e" to uppercase.
        // solve("coDE") = "code". Upper == lowercase.Change all to lowercase.

        //  public static string Solve(string s)
        //  {
        //      return s.Count(char.IsLower) < s.Length / 2 ? s.ToUpper() : s.ToLower();
        //  }

        // Day 10 - Persistent

        // Write a function, persistence, that takes in a positive parameter num and returns its multiplicative persistence, which is the number of times you must multiply the digits in num until you reach a single digit.
        //
        // For example:
        //
        //  persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
        //                       // and 4 has only one digit
        //
        //  persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
        //                        // 1*2*6 = 12, and finally 1*2 = 2
        //
        //  persistence(4) == 0 // because 4 is already a one-digit number

        // public static int Persistence(long n)
        // {
        //     int count = 0;
        //     while (n > 9)
        //     {
        //         count++;
        //         n = n.ToString().Select(digit => int.Parse(digit.ToString())).Aggregate((x, y) => x * y);
        //     }
        //     return count;
        // }

        // Day ??? - Find the odd int

        // Given an array of integers, find the one that appears an odd number of times.
        //
        // There will always be only one integer that appears an odd number of times.

        // public static int find_it(int[] seq)
        // {
        //     int arrSize = seq.Length;
        //     for (int i = 0; i < arrSize; i++)
        //     {
        //         int count = 0;
        // 
        //         for (int j = 0; j < arrSize; j++)
        //         {
        //             if (seq[i] == seq[j])
        //                 count++;
        //         }
        //         if (count % 2 != 0)
        //             return seq[i];
        //     }
        // 
        //     return -1;
        // }


        // Build Tower

        // Build Tower
        // Build Tower by the following given argument:
        // number of floors(integer and always greater than 0).
        // 
        // Tower block is represented as *
        // 
        // C#: returns a string[];
        // PHP: returns an array;
        // C++: returns a vector<string>;
        // Haskell: returns a[String];
        // Ruby: returns an Array;
        // Lua: returns a Table;
        // Have fun!
        // 
        // for example, a tower of 3 floors looks like below
        // 
        // [
        //   '  *  ',
        //   ' *** ',
        //   '*****'
        // ]
        // and a tower of 6 floors looks like below
        // 
        // [
        //   '     *     ',
        //   '    ***    ',
        //   '   *****   ',
        //   '  *******  ',
        //   ' ********* ',
        //   '***********'
        // ]
        // public static string[] TowerBuilder(int nFloors)
        // {
        //     var result = new string[nFloors];
        //     for (int i = 0; i < nFloors; i++)
        //         result[i] = string.Concat(new string(' ', nFloors - i - 1),
        //                                   new string('*', i * 2 + 1),
        //                                   new string(' ', nFloors - i - 1));
        //     return result;
        // }

        // Sort the oddd

        // You will be given an array of numbers.You have to sort the odd numbers 
        // in ascending order while leaving the even numbers at their original positions.

       // Examples
       // [7, 1]  =>  [1, 7]
       // [5, 8, 6, 3, 4]  =>  [3, 8, 6, 5, 4]
       // [9, 8, 7, 6, 5, 4, 3, 2, 1, 0]  =>  [1, 8, 3, 6, 5, 4, 7, 2, 9, 0]

        public static int[] SortArray(int[] array)
        {
            //temp variable for holding larger value for switching
            int temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                //If the value is 'even' continue with outer loop
                if (array[i] % 2 == 0)
                    continue;

                //Inner loop to compare array values
                for (int j = (i + 1); j < array.Length; j++)
                {
                    //If this value is not even do comparison
                    if (array[j] % 2 != 0)
                    {
                        //If the left value is greater than the right value
                        //swap them
                        if (array[i] > array[j])
                        {
                            temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }

            return array;
        }

        private static void Main(string[] args)
        {
            int[] testArray = [9, 8, 7, 6, 5, 4, 3, 2, 1, 0];
            SortArray(testArray);
        }
    }
}