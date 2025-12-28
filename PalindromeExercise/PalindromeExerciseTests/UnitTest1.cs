using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("Racecar", true)]
        [InlineData("racecar", true)]
        [InlineData("hannah", true)]
        [InlineData("cloud", false)]
        [InlineData("kayak", true)]
        [InlineData("aaron", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsAPalindrome_Test(string word, bool expected)
        {
            //Arrange
            var ws = new WordSmith();
            //Act
            var actual = ws.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
