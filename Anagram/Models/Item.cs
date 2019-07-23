using System;
namespace Anagram.Models
{
    public class AnagramTracker
    {

        public static bool Tracker(string word1, string word2)
        {
            //
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
