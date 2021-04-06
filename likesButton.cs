using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    public static class likesButton
    {
        public static string Likes(string[] name)
        {
            string toReturn = "";
            if (name.Length < 1 || name == null)
            {
                toReturn = "no one likes this";
            }
            if (name.Length == 1)
            {
                toReturn = $"{name[0]} likes this";
            }
            if (name.Length == 2)
            {
                toReturn = $"{name[0]} and {name[1]} like this";
            }
            if (name.Length == 3)
            {
                toReturn = $"{name[0]}, {name[1]} and {name[2]} like this";
            }
            if (name.Length > 3)
            {
                toReturn = $"{name[0]}, {name[1]} and {name.Length - 2} others like this";
            }
            return toReturn;
        }



    }
}
