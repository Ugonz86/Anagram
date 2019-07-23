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
            //Arrange



            //Act
            // Tracker ("beard", "bread");


            //Assert
            Assert.AreEqual(true, AnagramTracker.Tracker("beard", "bread"));

        }



    }
}
