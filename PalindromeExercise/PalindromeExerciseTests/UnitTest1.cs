using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("mom", true)]
        [InlineData("civic", true)]
        [InlineData("kayak", true)]
        [InlineData("coding", false)]
        [InlineData("c-sharp", false)]
        [InlineData("", false)]
        [InlineData(null, false)]
        public void IsPalindrome(string word, bool expected)
        {
            // Arrange
            var phrase = new WordSmith();
            // Act
            var actual = phrase.IsAPalindrome(word.ToLower());
            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
