/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
namespace palindromenumber
{
    public class Solution
    {
        public bool IsPalindrome(int x)
        {
            int reverse = 0;
            int remainder = x;
            while (remainder >= 1)
            {
                reverse = reverse * 10 + remainder % 10;
                remainder /= 10;
            }
            return x == reverse;
        }
    }
}
// @lc code=end
