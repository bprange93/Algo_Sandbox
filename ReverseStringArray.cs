using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class ReverseStringArray
    {
        public void reverseStringArray(string word)
        {
            char[] temp = word.ToCharArray();
            Array.Reverse(temp);
            Console.WriteLine(temp);
            Console.ReadLine();
        }
    }
}
