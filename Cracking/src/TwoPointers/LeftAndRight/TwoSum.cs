namespace Cracking.TwoPointers.LeftAndRight;

public class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        if (nums == null || nums.Length == 0)
        {
            throw new ArgumentException(null, nameof(nums));
        }

        var left = 0;
        var right = nums.Length - 1;

        while (right > left)
        {
            var sum = nums[left] + nums[right];

            if (target == sum)
            {
                return [left, right];
            }

            if (sum > target)
            {
                --right;
            }
            else
            {
                ++left;
            }
        }


        throw new ArgumentException("no soltion.");
    }
}