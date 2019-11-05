using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Please write your name here:");
            string name = ReadLine();
            char[] characters = name.ToCharArray();
            Array.Reverse(characters);
            string reverseName = new string(characters);
            bool checkIfPalindrome = name.Equals(reverseName, StringComparison.OrdinalIgnoreCase);
            if (checkIfPalindrome == true)
            {
                WriteLine(name + " is a palindrome!");
            }
            else
            {
                WriteLine(name + " isn't a palindrome");
            }
            ReadLine();
        }
    }
}
