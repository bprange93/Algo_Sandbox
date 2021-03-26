using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solution solution = new Solution();
            //solution.runSolution();

            //Palindrome palindrome = new Palindrome();
            //palindrome.palindromeTest();

            //ReverseString reverseString = new ReverseString();
            //reverseString.reverseString();

            //Anagram anagram = new Anagram();
            //anagram.anagramTest();

            ReverseStringArray reverseStringArray = new ReverseStringArray();
            reverseStringArray.reverseStringArray("cyclone");
        }
    }
}
