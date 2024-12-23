/*
 * @lc app=leetcode id=5 lang=csharp
 *
 * [5] Longest Palindromic Substring
 */

// @lc code=start
public class Solution {
    public static bool IsPalindrome(string s){
        if(s.Length <= 1) return true;
        bool uneven = s.Length % 2 == 1;
        int upper = uneven ? (s.Length/2)+1 : s.Length/2;
        for(int i = (s.Length/2)-1; i >= 0; i--){
            if(s[i] != s[upper]) return false;
            upper++;
        }
        return true;
    }

    public string LongestPalindrome(string s) {
        if(s.Length == 0) return "";
        int count = s.Length;
        int startIdx = 0;
        while(count > 1){
            string current = s.Substring(startIdx, count);
            if(IsPalindrome(current)){
                return current;
            } else {
                if(startIdx + count == s.Length){
                    count--;
                    startIdx = 0;
                } else {
                    startIdx ++;
                }
            }
        }
        return s[0..1];

    }
}
// @lc code=end

