/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
namespace validParentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            char[] openStack = new char[(s.Length / 2) + 1];
            int nextStackIdx = 0;
            char current;
            for (int i = 0; i < s.Length; i++)
            {
                current = s[i];
                if (current == '(' || current == '[' || current == '{')
                {
                    if (nextStackIdx < openStack.Length - 1)
                    {
                        openStack[nextStackIdx] = current;
                        nextStackIdx++;
                    }
                    else
                        return false;
                }
                else if (current == ')')
                {
                    if (nextStackIdx > 0 && openStack[nextStackIdx - 1] == '(')
                        nextStackIdx--;
                    else
                        return false;
                }
                else if (current == ']')
                {
                    if (nextStackIdx > 0 && openStack[nextStackIdx - 1] == '[')
                        nextStackIdx--;
                    else
                        return false;
                }
                else
                {
                    if (nextStackIdx > 0 && openStack[nextStackIdx - 1] == '{')
                        nextStackIdx--;
                    else
                        return false;
                }
            }
            return nextStackIdx == 0;
        }
    }
}
// @lc code=end
