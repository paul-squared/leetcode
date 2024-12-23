/*
 * @lc app=leetcode id=3 lang=csharp
 *
 * [3] Longest Substring Without Repeating Characters
 */

// @lc code=start
namespace LengthOfLongestSubstring{
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            if (s.Length == 0) return 0;
            if (s.Length == 1) return 1;
            Dictionary<char, int> lastSeen = [];

            int maxLen = 0;
            int startIdx = 0;
            char current;
            for (int i = 0; i < s.Length; i++)
            {
                current = s[i];
                int len;
                if (lastSeen.TryGetValue(current, out int lastIdx) && lastIdx >= startIdx) {
                    startIdx = lastIdx + 1;
                    len = i - lastIdx;
                } else {
                    len = i - startIdx +1;
                }
                if (len > maxLen) maxLen = len;
                lastSeen[current] = i;
            }
            return maxLen;
        }
    }
}
// @lc code=end

