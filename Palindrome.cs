using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    public static class Palindrome
    {
        //static to be accessible from anywhere. 
        public static void palindromeTest() {

            //instantiate a string variable
            string word;
            //ask for the user to enter a string of some sort
            Console.WriteLine("Enter a word");
            //set the response as the string to be checked. 
            word = Console.ReadLine();

            //set char[] temp to get an array instantiated, set = to word then use .ToCharArray() to turn the string
            //into each letter is a number in the array.
            char[] temp = word.ToCharArray();
            //take that array and reverse each character. 
            Array.Reverse(temp);
            //instantiate new variable to take in the temp string. 
            string reverseWord = new string(temp);

            //if statement to compare the words to see if palindrome or not.
            //.ToLower added incase any letter is capitalized so that won't throw a not palindrome
            //when it is just is a different character according to the computer when it reads. 
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
