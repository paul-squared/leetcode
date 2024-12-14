/*
 * @lc app=leetcode id=70 lang=csharp
 *
 * [70] Climbing Stairs
 */

// @lc code=start
namespace ClimbStairs
{
    public class Solution
    {
        private static void CalcFib(int[] arr)
        {
            int secondLast = arr[0];
            int last = arr[1];
            arr[0] = last;
            arr[1] = last + secondLast;
        }

        public int ClimbStairs(int n)
        {
            int[] fib = [0, 1];
            for (int i = 0; i < n; i++)
            {
                CalcFib(fib);
            }
            return fib[1];
        }
    }
}
// @lc code=end
