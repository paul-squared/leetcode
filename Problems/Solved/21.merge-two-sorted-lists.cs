/*
 * @lc app=leetcode id=21 lang=csharp
 *
 * [21] Merge Two Sorted Lists
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
namespace MergeTwoSortedLists
{
    public class ListNode
    {
        public int val;
        public ListNode? next;

        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
        {
            ListNode resultBegin;
            ListNode resultCurrent;

            if (list1 != null && list2 != null)
            {
                if (list1.val <= list2.val)
                {
                    resultBegin = list1;
                    resultCurrent = resultBegin;
                    list1 = list1.next;
                }
                else
                {
                    resultBegin = list2;
                    resultCurrent = resultBegin;
                    list2 = list2.next;
                }
            }
            else if (list1 != null)
                return list1;
            else if (list2 != null)
                return list2;
            else
                return null;

            while (list1 != null || list2 != null)
            {
                if (list1 == null)
                {
                    resultCurrent.next = list2;
                    break;
                }
                else if (list2 == null)
                {
                    resultCurrent.next = list1;
                    break;
                }
                else if (list1.val <= list2.val)
                {
                    resultCurrent.next = list1;
                    resultCurrent = resultCurrent.next;
                    list1 = list1.next;
                }
                else
                {
                    resultCurrent.next = list2;
                    resultCurrent = resultCurrent.next;
                    list2 = list2.next;
                }
            }

            return resultBegin;
        }
    }
}
// @lc code=end
