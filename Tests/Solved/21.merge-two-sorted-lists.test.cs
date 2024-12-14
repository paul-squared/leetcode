namespace MergeTwoSortedLists
{
    [TestFixture]
    public class SolutionTests
    {
        private Solution solution;

        private static bool CheckListSorted(ListNode? node)
        {
            int? prevVal = node?.val;
            List<int?> outputVals = [];
            outputVals.Add(prevVal);
            while (true)
            {
                node = node?.next;
                if (node == null)
                    break;
                if (prevVal > node.val)
                    return false;
                outputVals.Add(node.val);
                prevVal = node.val;
            }
            // Console.WriteLine($"[{string.Join(", ", outputVals)}]");
            return true;
        }

        [SetUp]
        protected void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void Case1()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(9)));
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case2()
        {
            ListNode list1 = new ListNode(5, new ListNode(19, new ListNode(33)));
            ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(9)));
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case3()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode list2 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case4()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode list2 = new ListNode(5, new ListNode(19, new ListNode(99)));
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case5()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode list2 = new ListNode();
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case6()
        {
            ListNode list1 = new ListNode();
            ListNode list2 = new ListNode();
            ListNode? result = solution.MergeTwoLists(list1, list2);
            Assert.That(CheckListSorted(result), Is.True);
        }

        [Test]
        public void Case7()
        {
            ListNode? result = solution.MergeTwoLists(null, null);
            Assert.That(CheckListSorted(result), Is.True);
        }
    }
}
