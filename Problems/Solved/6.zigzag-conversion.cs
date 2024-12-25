/*
 * @lc app=leetcode id=6 lang=csharp
 *
 * [6] Zigzag Conversion
 */

// @lc code=start
using System.Text;

namespace Convert
{
    public class Solution
    {
        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;
            StringBuilder[] rows = new StringBuilder[numRows];
            for (int i = 0; i < rows.Length; i++)
            {
                rows[i] = new StringBuilder();
            }
            int rowIdx = 0;
            bool countUp = true;
            for (int i = 0; i < s.Length; i++)
            {
                rows[rowIdx].Append(s[i]);

                if ((rowIdx <= 0 && !countUp) || (rowIdx >= numRows - 1 && countUp))
                    countUp = !countUp;
                if (countUp)
                    rowIdx++;
                else
                    rowIdx--;
            }
            return string.Join("", rows.Select(x => x.ToString()));
        }
    }
}
// @lc code=end
