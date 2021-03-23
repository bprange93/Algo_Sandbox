using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class ReverseString
    {
        public void reverseString()
        {
            //Ask for them to input a string to be reversed. 
            string inputString;
            Console.WriteLine("Enter string you want reversed");
            inputString = Console.ReadLine();

            //set a resultString to be taken into the Console.Writline
            //Use the string.Join in order to concatenate all of the variables in the string
            //use the .Split in order to be able to separate each word by a space if used. 
            // Lambda into a new String in order to bring the string back in a new form (.Reverse)
            //in order to reverse the string. 
            //.ToArray because the .Reverse needs to be in an array which strings are not automatically put into. 
            string resultString = string.Join(" ", inputString.Split(' ').Select(x => new String(x.Reverse().ToArray())));
            Console.WriteLine(resultString);
            Console.ReadLine();
        }
    }
}
