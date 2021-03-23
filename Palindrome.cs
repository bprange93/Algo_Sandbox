using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class Palindrome
    {
        public void palindromeTest() {
            string word;

            Console.WriteLine("Enter a word");
            word = Console.ReadLine();

            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            string reverseWord = new string(temp);

            if (word.ToLower().Equals(reverseWord.ToLower()))
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not a palindrome");
            }
            Console.ReadLine();
        }

    }
}
