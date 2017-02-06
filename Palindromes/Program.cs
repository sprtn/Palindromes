using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Program
    {
        static void Main(string[] args)
        {
            AlwaysRun();
        }
        
        private static void AlwaysRun()
        {
            Console.WriteLine("Enter a word to find out if it's a palindrome: ");
            string word = Console.ReadLine();
            Console.WriteLine(IsPalindrome(word) + "\n");
            AlwaysRun();
        }

        private static bool IsPalindrome(string word)
        {
            char[] charArray = word.ToLower().ToCharArray();
            Array.Reverse(charArray);
            return word.ToLower() == new string(charArray) ? true : false;
        }
    }
}