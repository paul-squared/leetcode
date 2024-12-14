/*
 * @lc app=leetcode id=67 lang=csharp
 *
 * [67] Add Binary
 */

// @lc code=start
using System.Text;

namespace AddBinary
{
    public class Solution
    {
        public string AddBinary(string a, string b)
        {
            StringBuilder result = new StringBuilder();
            int carry = 0;

            int loopEnd = Math.Max(a.Length, b.Length);
            for (int i = 1; i <= loopEnd; i++)
            {
                char currentA = i > a.Length ? '0' : a[^i];
                char currentB = i > b.Length ? '0' : b[^i];

                if (currentB == '1' && currentA == '1')
                {
                    if (carry > 0)
                    {
                        result.Insert(0, '1');
                    }
                    else
                    {
                        carry++;
                        result.Insert(0, '0');
                    }
                }
                else if (currentB == '0' && currentA == '0')
                {
                    if (carry > 0)
                    {
                        carry--;
                        result.Insert(0, '1');
                    }
                    else
                    {
                        result.Insert(0, '0');
                    }
                }
                else
                {
                    if (carry > 0)
                    {
                        result.Insert(0, '0');
                    }
                    else
                    {
                        result.Insert(0, '1');
                    }
                }
            }
            if (carry > 0)
                result.Insert(0, '1');

            return result.ToString();
        }
    }
}
// @lc code=end
