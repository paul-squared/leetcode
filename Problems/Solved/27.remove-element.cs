/*
 * @lc app=leetcode id=27 lang=csharp
 *
 * [27] Remove Element
 */

// @lc code=start
namespace RemoveElement
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int removed = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                int current = nums[i];
                if (current == val)
                    removed++;
                else
                {
                    if (removed > 0)
                        nums[i - removed] = nums[i];
                }
            }
            return nums.Length - removed;
        }
    }
}
// @lc code=end
