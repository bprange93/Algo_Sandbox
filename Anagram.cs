﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Test_2
{
    class Anagram
    {
        public void anagramTest()
        {
            string word1;
            string word2;
            int firstWordLetters;
            int secondWordLetters;


            //ask for words to be tested for anagrams
            //compare the letters in the word
            //find a way to tell how many letters to add to make anagram
            Console.WriteLine("Enter first word for anagram: ");
            word1 = Console.ReadLine();
            Console.WriteLine("Enter second word to be compared to first");
            word2 = Console.ReadLine();
            char[] temp = word1.ToCharArray();
            char[] temp1 = word2.ToCharArray();
            Array.Sort(temp);
            Array.Sort(temp1);

            string anagramWord = new string(temp);
            string isAnagram = new string(temp1);

            if (anagramWord.Equals(isAnagram))
            {
                Console.WriteLine("Anagram");
                

            }
            else
            {
                //int anagramWord.IndexOf();
                //int result1 = int.Parse(isAnagram);
                //int lettersNeeded = (result - result1);
                //result.CompareTo(result1);
                Console.WriteLine("Not Anagram");
            }
            Console.ReadLine();

            
            //find way to turn string into total characters in word
            //anagramWord.Count() = firstWordLetters;
            //word2.Count() = secondWordLetters;
            //int lettersNeeded;
        }

    }
}
