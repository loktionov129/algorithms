using Cracking.TwoPointers.LeftAndRight;

namespace Cracking.Tests.TwoPointers.LeftAndRight;

public class TwoSumSolutionTests
{
    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 1, 2, 3, 4, 6 }, 10, new[] { 3, 4 })]
    [InlineData(new[] { -5, -2, 0, 3, 8 }, 1, new[] { 1, 3 })]
    [InlineData(new[] { -2, 1, 6, 9, 12, 21 }, 18, new[] { 2, 4 })]
    public void TwoSum_WhenSolutionExists_ReturnsCorrectIndices(int[] nums, int target, int[] expected)
    {
        // Act
        var result = TwoSumSolution.TwoSum(nums, target);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void TwoSum_WithMinimumValidInput_ReturnsIndices()
    {
        // Arrange
        int[] nums = { 1, 5 };
        int target = 6;

        // Act
        var result = TwoSumSolution.TwoSum(nums, target);

        // Assert
        Assert.Equal(new[] { 0, 1 }, result);
    }

    [Fact]
    public void TwoSum_WhenNoSolution_ThrowsArgumentException()
    {
        // Arrange
        int[] nums = { 1, 2, 3 };
        int target = 10;

        // Act & Assert
        var exception = Assert.Throws<ArgumentException>(() => 
            TwoSumSolution.TwoSum(nums, target));
        Assert.Equal("no soltion.", exception.Message);
    }

    [Fact]
    public void TwoSum_WhenArrayIsNull_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => 
            TwoSumSolution.TwoSum(null!, 5));
    }

    [Fact]
    public void TwoSum_WhenArrayIsEmpty_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => 
            TwoSumSolution.TwoSum(Array.Empty<int>(), 5));
    }
}
