/*
 * @lc app=leetcode id=66 lang=csharp
 *
 * [66] Plus One
 */

// @lc code=start
namespace PlusOne
{
    public class Solution
    {
        public int[] PlusOne(int[] digits)
        {
            bool carryOne = false;
            int current = digits[^1];
            if (current == 9)
            {
                digits[^1] = 0;
                carryOne = true;
            }
            else
            {
                current++;
                digits[^1] = current;
            }
            for (int i = digits.Length - 2; i >= 0; i--)
            {
                current = digits[i];
                if (carryOne)
                {
                    if (current == 9)
                    {
                        current = 0;
                    }
                    else
                    {
                        current++;
                        carryOne = false;
                    }
                }
                digits[i] = current;
            }
            if (carryOne && digits[0] == 0)
                return [1, .. digits];
            else
                return digits;
        }
    }
}
// @lc code=end
