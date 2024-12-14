/*
 * @lc app=leetcode id=13 lang=csharp
 *
 * [13] Roman to Integer
 */

// @lc code=start
namespace romantointeger
{
    public class Solution
    {
        public int RomanToInt(string s)
        {
            Dictionary<char, int> lut = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 },
            };

            int current;
            int last = 0;
            int result = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                current = lut[s[i]];
                if (current < last)
                    result -= current;
                else
                    result += current;
                last = current;
            }
            return result;
        }
    }
}
// @lc code=end
