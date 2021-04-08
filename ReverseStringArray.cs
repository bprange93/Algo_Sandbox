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

       
        public static string Order(string phrase)
        {
            if (phrase == "") return phrase;

            string[] words = phrase.Split(' ');
            string[] newWords = new string[words.Length];
            int wordsSorted = 1;
            for (int i = 0; i <= words.Length - 1; i++)
            {
                foreach (string word in words) 
                {

                    if (word.Contains(wordsSorted.ToString())) {
                        newWords[i] = word;
                        wordsSorted++;
                        break;
                    }
                }

            }

            string newString = "";
            foreach (var word in newWords)
                newString += word + " ";
            Console.WriteLine(newString);
            return newString;
        }

        public static string Order2(string words){
            if (string.IsNullOrEmpty(words)) return words;
                return string.Join(" ", words.Split(' ')
                    .OrderBy(s => s.ToList().Find(c => char.IsDigit(c))));

        }



    }
}
