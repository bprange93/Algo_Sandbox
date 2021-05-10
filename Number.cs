using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    static class Number
    {
        public static int digitalRoot(long n)
        {
            //Digital Root name of the Kata in Codewars
            //turn n into an array
            //needs to take in each charater as a position (Possibly split the array)
            //if array over 9 must be split and reduced again
            //if the position is more than 1 it needs to add the remaining numbers to it each being its own character such as 1+2+3 if the number is 123
            //Needs to keep going down until it is a single digit
            //Can't be a negative integer

            return (int)((n - 1) % 9 + 1);
        }
    }
}
