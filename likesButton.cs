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
            List<string> names; 
            //at 0 position no one likes
            //at 1 position persons name likes this
            //at 2 position person1 and person 2 like this
            //at 3 position person1 person2 and person3 like this
            //at 4+ postition person1 person2 and X others like this
            name[0] = "no one likes this";
            for(int i = name.Length; i < 4; i++)
            {
                name[1] = "\nname[1]: likes this";

                
            }
            
        }

    }
}
