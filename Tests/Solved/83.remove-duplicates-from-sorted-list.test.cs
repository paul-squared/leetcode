namespace DeleteDuplicates{
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
            return true;
        }

        private static bool CheckListNoDuplicates(ListNode? node){
            HashSet<int> seen = [];
            while(true){
                if(seen.Contains(node.val)) return false;
                seen.Add(node.val);
                if(node.next == null) break;
                node = node.next;
            }
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
            ListNode? result = solution.DeleteDuplicates(list1);
            Assert.That(CheckListSorted(result), Is.True);
            Assert.That(CheckListNoDuplicates(result), Is.True);
        }

        [Test]
        public void Case2()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(3))));
            ListNode? result = solution.DeleteDuplicates(list1);
            Assert.That(CheckListSorted(result), Is.True);
            Assert.That(CheckListNoDuplicates(result), Is.True);
        }

        [Test]
        public void Case3()
        {
            ListNode list1 = new ListNode(1, new ListNode(1, new ListNode(1, new ListNode(1))));
            ListNode? result = solution.DeleteDuplicates(list1);
            Assert.That(CheckListSorted(result), Is.True);
            Assert.That(CheckListNoDuplicates(result), Is.True);
        }

        [Test]
        public void Case4()
        {
            ListNode list1 = new ListNode(-2, new ListNode(-2, new ListNode(-1, new ListNode(-1))));
            ListNode? result = solution.DeleteDuplicates(list1);
            Assert.That(CheckListSorted(result), Is.True);
            Assert.That(CheckListNoDuplicates(result), Is.True);
        }
    }
}