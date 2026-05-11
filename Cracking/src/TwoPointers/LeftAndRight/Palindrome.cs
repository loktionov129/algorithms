namespace Cracking.TwoPointers.LeftAndRight;

public class PalindromeSolution
{
    public static bool IsPalindrome(string s)
    {
        for(var idx = 0; idx < s.Length / 2; ++idx)
        {
            if (s[idx] != s[s.Length -1 -idx])
            {
                return false;
            }
        }

        return true;
    }
} 