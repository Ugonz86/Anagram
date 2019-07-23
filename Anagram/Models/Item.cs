using System;
using System.Collections.Generic;

namespace Anagram.Models
{
    public class AnagramTracker
    {
        public static List<string> SelectFromList(string inputWord, string[] inputList)
        {
            List<string> anagrams = new List<string>();

            for (int i = 0; i < inputList.Length; i ++)
            {
                bool isAnagram = Tracker(inputWord, inputList[i]);
                if (isAnagram)
                {
                    anagrams.Add(inputList[i]);
                }
            }

            return anagrams;
        }

        public static bool Tracker(string word1, string word2)
        {
            char[] char1 = word1.ToLower() .ToCharArray();
            char[] char2 = word2.ToLower() .ToCharArray();
            //
            Array.Sort (char1);
            Array.Sort (char2);
            //
            string NewWord1 = string.Join("", char1);
            string NewWord2 = string.Join("", char2);

            if (NewWord1 == NewWord2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
