using Anagram.Models;
using System;
using System.Collections.Generic;

class Program
{

    private static void Main()
    {
        Console.WriteLine("Welcome to the Anagram Tracker!");

        Console.WriteLine("Please enter the first word: ");
        string inputWord = Console.ReadLine();

        Console.WriteLine("Please enter a list of words, separated by commas: ");
        string stringListWords = Console.ReadLine();

        string[] inputList = stringListWords.Split(',');

        List<string> result = AnagramTracker.SelectFromList(inputWord, inputList);

        Console.WriteLine($"Your input word is '{inputWord}'. The following words from your list are anagrams of {inputWord}:");

        for (int i = 0; i < result.Count; i++)
        {
            Console.WriteLine(result[i]);
        }

        // if (result)
        // {
        //     Console.WriteLine("The words \"{0}\" and \"{1}\" are Anagrams!", word1, word2);
        // }
        // else
        // {
        //     Console.WriteLine("The words \"{0}\" and \"{1}\" are not Anagrams. Try again!", word1, word2);
        // }
    }
}
