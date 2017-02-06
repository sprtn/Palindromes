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
        /// Create a character array with lower-case letters from the input
        /// Reverse the order of the array
        /// Put back into a string, 
        /// validate it against the input string.
        /// 
        /// </summary>
        /// <param name="word"> Word here is the input from the ReadLine in AlwaysRun. </param>
        /// <returns></returns>
        private static bool IsPalindrome(string word)
        {
            char[] charArray = word.ToLower().ToCharArray();
            Array.Reverse(charArray);
            if (word == new string(charArray)) {
                return true;
            } else {
                return false;
            }
        }
    }
}
/*
 * Note: This program doesn't work 100%.
 * It functions in a weird way when long
 * strings are being inputted.
 * 
 * For example: "Agnes i senga" does not
 * equal true, according to this program,
 * while it is. "L o l", however, returns
 * true. There must be a part of this I
 * didn't quite understand yet.
 */