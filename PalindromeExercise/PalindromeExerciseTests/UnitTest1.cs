using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
       
            [Theory]
            [InlineData("racecar", true)]
            [InlineData("hello", false)]
            [InlineData("kayak", true)]
            [InlineData("palindrome", false)]
            [InlineData("madam", true)]

            public void PalindromeTest(string word, bool expected)
            {
                var test = new WordSmith();
                var actual = test.IsAPalindrome(word);
                Assert.Equal(expected, actual);
            }
    }
}
