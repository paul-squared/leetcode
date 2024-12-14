/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
namespace twosums
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> valueIndex = new Dictionary<int, int>();
            for (int i = 0; i <= nums.Length; i++)
            {
                int curVal = nums[i];
                int complement = target - curVal;
                if (valueIndex.TryGetValue(complement, out int compIdx))
                {
                    return [i, compIdx];
                }
                else
                {
                    if (!valueIndex.ContainsKey(curVal))
                        valueIndex.Add(curVal, i);
                }
            }
            return [];
        }
    }
}
// @lc code=end
