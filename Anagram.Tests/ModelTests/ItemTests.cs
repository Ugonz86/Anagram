using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Anagram.Models;

namespace Anagram.Tests
{
    [TestClass]
    public class AnagramTrackerTest
    {
        [TestMethod]
        public void Tracker_DeterminesIfAnagram_True()
        {
            Assert.AreEqual(true, AnagramTracker.Tracker("beard", "bread"));
        }

        [TestMethod]
        public void SelectFromList_DeterminesIfAnagramFromList_BreadBared()
        {
            // Arrange
            List<string> possibleAnagrams = new List<string>() {"bread", "banana", "oranges", "bared"};
            string wordToCompareTo = "beard";

            // Act
            List<string> result = AnagramTracker.SelectFromList(wordToCompareTo, possibleAnagrams);

            // Assert
            Assert.AreEqual("bared", result[1]);
        }

    }
}
