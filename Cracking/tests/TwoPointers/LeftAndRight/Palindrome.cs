using Cracking.TwoPointers.LeftAndRight;

namespace Cracking.Tests.TwoPointers.LeftAndRight;

public class PalindromeSolutionTests
{
    [Theory]
    [InlineData("", true)]
    [InlineData("racecar", true)]
    [InlineData("a", true)]
    [InlineData("aa", true)]
    [InlineData("aaa", true)]
    [InlineData("aaaa", true)]
    [InlineData("abba", true)]
    [InlineData("abcba", true)]
    [InlineData("level", true)]
    [InlineData("kayak", true)]
    [InlineData("12321", true)]
    [InlineData("hello", false)]
    [InlineData("world", false)]
    [InlineData("12345", false)]
    public void Test_IsPalindrome_Simple(string input, bool expected)
    {
        Assert.Equal(expected, PalindromeSolution.IsPalindrome(input));
    }
}
