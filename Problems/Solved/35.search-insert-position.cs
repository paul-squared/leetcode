/*
 * @lc app=leetcode id=35 lang=csharp
 *
 * [35] Search Insert Position
 */

// @lc code=start
namespace SearchInsertPosition
{
    public class Solution
    {
        public int SearchInsert(int[] nums, int target)
        {
            int low = 0;
            int high = nums.Length - 1;

            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                int current = nums[mid];
                if (current == target)
                {
                    return mid;
                }
                else if (current < target)
                    low = mid + 1;
                else
                {
                    high = mid - 1;
                }
            }
            return low;
        }
    }
}
// @lc code=end
