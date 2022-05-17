using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("radar", true)] // ← you will need to put some test data and expected result here.  
        [InlineData("words", false)] // ← you will need to put some test data and expected result here.  
        [InlineData("Radar", true)] // ← you will need to put some test data and expected result here.  

        // For example [InlineData(“racecar”, true)]
        public void PalindromeTest(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();

            //Act
            var actual = wordSmith.IsAPalindrome(word);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
