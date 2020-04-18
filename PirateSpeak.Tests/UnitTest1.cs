using System;
using System.Collections.Generic;
using Xunit;

namespace PirateSpeak.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange
            var jumbledWord = "ortsp";
            var possibleWords = new List<string>() { "sport", "parrot", "ports", "matey" };
            var expectedResult = new List<string>() { "sport", "ports" }.ToString();
            var speak = new PirateWords();

            // Act
            var actualResult = speak.Words(jumbledWord, possibleWords);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void Test2()
        {
            // Arrange
            var jumbledWord = "abrrell";
            var possibleWords = new List<string>() { "barrel", "harold", "farrel" };
            var expectedResult = new List<string>() { "barrel" }.ToString();
            var speak = new PirateWords();

            // Act
            var actualResult = speak.Words(jumbledWord, possibleWords);

            // Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
