using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    /// <summary>
    /// A simple program which checks whether your input is the same backwards.
    /// 
    /// The AlwaysRun-method is simply a self-calling method which allows you to keep checking for palindromes.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            AlwaysRun();
        }

        /// <summary>
        /// A self-calling method, takes in user input from the built-in
        /// Console.ReadLine function, and calls for the method.
        /// Upon finishing, it calls the method again after creating
        /// space between the runs.
        /// </summary>

        private static void AlwaysRun()
        {
            Console.WriteLine("Enter a word to find out if it's a palindrome: ");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word));
            Console.WriteLine();
            AlwaysRun();
        }


        /// <summary>
        /// Takes the input and returns true or false based on whether the string
        /// is the same backwards as it is forwards. The method is a bit compact,
        /// but the logic behind is as follows:
        /// 
        /// 1. Create a character array with lower-case letters from the input
        /// 2. Override the input to be lower case, for the test later (This gave me an unnecessary headache)
        /// 3. Reverse the order of the array
        /// 4. Put back into a string and validate it against the input string.
        /// 5. return true or false
        /// 
        /// </summary>
        /// <param name = "word"> Word here is the input from the ReadLine in AlwaysRun. </param>
        /// <returns></returns>
        private static bool IsPalindrome(string word)
        {
            char[] charArray = word.ToLower().ToCharArray();
            word = new string(charArray);
            Array.Reverse(charArray);
            if (word == new string(charArray)) {
                return true;
            } else {
                return false;
            }
        }
    }
}