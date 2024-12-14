/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
namespace AddTwoNumbers
{
    public class ListNode
    {
        public int val;
        public ListNode next;

        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode firstHead = new(0);
            ListNode currentHead = firstHead;
            int carry = 0;
            int exponent = 0;
            while (true)
            {
                int newNodeVal = l1.val + l2.val + carry;
                if (newNodeVal >= 10)
                {
                    carry = newNodeVal / 10;
                    newNodeVal %= 10;
                }
                else
                    carry = 0;
                currentHead.next = new ListNode(newNodeVal);
                currentHead = currentHead.next;

                if (l1.next == null && l2.next == null && carry == 0)
                    break;
                if (l1.next == null)
                    l1.val = 0;
                else
                    l1 = l1.next;
                if (l2.next == null)
                    l2.val = 0;
                else
                    l2 = l2.next;

                exponent++;
            }
            return firstHead.next;
        }
    }
}
// @lc code=end
