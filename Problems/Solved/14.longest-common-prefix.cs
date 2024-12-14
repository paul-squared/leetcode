/*
 * @lc app=leetcode id=14 lang=csharp
 *
 * [14] Longest Common Prefix
 */

// @lc code=start
namespace longestCommonPrefix
{
    public class Solution
    {
        public string LongestCommonPrefix(string[] strs)
        {
            if (strs.Length == 1)
                return strs[0];
            HashSet<string> prefixes = [];

            string current = strs[0];
            int maxLength = current.Length;
            for (int i = 0; i < maxLength; i++)
            {
                prefixes.Add(current[..(i + 1)]);
            }

            for (int strsIdx = 1; strsIdx < strs.Length; strsIdx++)
            {
                current = strs[strsIdx];
                if (current.Length < maxLength)
                    maxLength = current.Length;
                for (int strIdx = maxLength; strIdx >= 0; strIdx--)
                {
                    maxLength = strIdx;
                    if (prefixes.Contains(current[..maxLength]))
                    {
                        break;
                    }
                }
                // if(maxLength == 0) break;
            }
            return current[..maxLength];
        }
    }
}
// @lc code=end
