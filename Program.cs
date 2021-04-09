using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class Program
    {
        //made static to be able to access without calling class 
        static void Main(string[] args)
        {
            //Solution solution = new Solution();
            //solution.runSolution();

            //Palindrome.palindromeTest();

            //ReverseString reverseString = new ReverseString();
            //reverseString.reverseString();

            //Anagram anagram = new Anagram();
            //anagram.anagramTest();

            //ReverseStringArray reverseStringArray = new ReverseStringArray();
            //reverseStringArray.reverseArray();



            //Console.WriteLine("Please enter string to be reverse.");

            //string stringArray = Console.ReadLine();


            //for (int i = stringArray.Length - 1; i >= 0; i--)
            //{

            //    char temp = stringArray.Last();
            //    Console.WriteLine(temp);
            //}

            //Console.ReadLine();

            //Solution solution = new Solution();
            //solution.Mulitply("2", "3");

            //Solution solution = new Solution();
            //Console.WriteLine(solution.validPin("9461"));

            //Console.WriteLine(likesButton.Likes(new string[] { })) ;
            //Console.WriteLine(likesButton.switchLikes(new string[] { "Sam", " Dean", " Bobby", " Castiel" }));
            //string[] dir = { "NORTH ", "SOUTH ", "WEST ",  "SOUTH ", "EAST " };
            //string result = String.Concat(likesButton.dirReduc2(dir));            
            //Console.WriteLine(result);

            // Console.ReadLine();
            //likesButton.dirReducPushPop(new string[] { "NORTH", "SOUTH", "WEST", "SOUTH", "EAST", "WEST" });
            //Console.ReadLine();



            Console.WriteLine(ReverseStringArray.reverseWithLoop(new char[] { 'B','a','t','m','a','n'}));
            Console.ReadLine();
        }
    }
}
