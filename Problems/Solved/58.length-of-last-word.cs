/*
 * @lc app=leetcode id=58 lang=csharp
 *
 * [58] Length of Last Word
 */

// @lc code=start
namespace LengthOfLastWord
{
    public class Solution
    {
        public int LengthOfLastWord(string s)
        {
            String matches = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                char current = s[i];
                if (current == ' ' && !string.IsNullOrEmpty(matches))
                    return matches.Length;
                else if (current != ' ')
                {
                    matches += current;
                }
            }
            return matches.Length;
        }
    }
}
// @lc code=end
