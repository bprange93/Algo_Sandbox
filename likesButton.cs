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

        public static string switchLikes(string[] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                case 1: return $"{name[0]} likes this";
                case 2: return $"{name[0]} and {name[1]}like this";
                case 3: return $"{name[0]} and {name[1]} and {name[2]} like this";
                default: return $"{name[0]} and {name[1]} and {name.Length - 2} others like this";
            }
        }

        public static string[] dirReduc(string[] arr)
        {
            List<string> directionList = arr.ToList();
            int sCount = directionList.Count(d => d == "SOUTH");
            int nCount = directionList.Count(d => d == "NORTH");
            int eCount = directionList.Count(d => d == "EAST");
            int wCount = directionList.Count(d => d == "WEST");

            for(int i = 0; i < Math.Min(eCount, wCount); i++)
            {                
                directionList.Remove("EAST");
                directionList.Remove("WEST");
                
            }
            for (int i = 0; i < Math.Min(sCount, nCount); i++)
            {
                directionList.First();
                directionList.Remove("NORTH");
                directionList.Remove("SOUTH");
                
            }
            
            foreach(string direction in directionList)
            {
                Console.WriteLine(direction);
            }
            return directionList.ToArray();
            
            
        }

        public static string[] dirReduc2(String[] arr)
        {
            return Recursive(arr);
        }
        public static string[] Recursive(string[] arr)
        {
            string[] newArray;
            int newArrayLength = arr.Length;

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == "") continue;
                if(arr[i] == "NORTH " && arr[i + 1] =="SOUTH " ||
                    arr[i] == "SOUTH " && arr[i + 1] == "NORTH " ||
                    arr[i] == "EAST " && arr[i + 1] == "WEST " ||
                    arr[i] == "WEST " && arr[i + 1] == "EAST ")
                {
                    arr[i] = "";
                    arr[i + 1] = "";
                    newArrayLength -= 2;
                }
            }
            if (newArrayLength == arr.Length) return arr;
            int index = 0;
            newArray = new string[newArrayLength];
            foreach (var direction in arr) {
                if (direction != "")
                    newArray[index++] = direction;
                
            }

            return Recursive(newArray);
        }


    }
}
