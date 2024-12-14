/*
 * @lc app=leetcode id=26 lang=csharp
 *
 * [26] Remove Duplicates from Sorted Array
 */

// @lc code=start
namespace RemoveDuplicatesFromSortedArray
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            int removed = 0;
            int prev = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                int current = nums[i];
                if (current == prev)
                    removed++;
                else if (removed > 0)
                {
                    nums[i - removed] = current;
                }
                prev = current;
            }

            return nums.Length - removed;
        }
    }
}
// @lc code=end
