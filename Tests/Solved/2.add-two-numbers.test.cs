namespace AddTwoNumbers
{
    [TestFixture]
    public class SolutionTests
    {
        private Solution solution;

        private static int RetrieveOverallValue(ListNode l)
        {
            int result = 0;
            short exponent = 0;
            while (true)
            {
                result += l.val * ((int)Math.Pow(10, exponent));
                ListNode next = l.next;
                if (next != null)
                {
                    l = next;
                    exponent++;
                }
                else
                {
                    return result;
                }
            }
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
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(1263));
        }

        [Test]
        public void Case2()
        {
            ListNode list1 = new ListNode(5, new ListNode(1, new ListNode(3)));
            ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(9, new ListNode(3))));
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(4257));
        }

        [Test]
        public void Case3()
        {
            ListNode list1 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode list2 = new ListNode(1, new ListNode(2, new ListNode(3)));
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(642));
        }

        [Test]
        public void Case4()
        {
            ListNode list1 = new ListNode(0);
            ListNode list2 = new ListNode(0);
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(0));
        }

        [Test]
        public void Case5()
        {
            ListNode list1 = new ListNode(
                9,
                new ListNode(
                    9,
                    new ListNode(
                        9,
                        new ListNode(
                            9,
                            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))
                        )
                    )
                )
            );
            ListNode list2 = new ListNode(0);
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(99999999));
        }

        [Test]
        public void Case6()
        {
            ListNode list1 = new ListNode(
                9,
                new ListNode(
                    9,
                    new ListNode(
                        9,
                        new ListNode(
                            9,
                            new ListNode(9, new ListNode(9, new ListNode(9, new ListNode(9))))
                        )
                    )
                )
            );
            ListNode list2 = new ListNode(9, new ListNode(9, new ListNode(9)));
            ListNode result = solution.AddTwoNumbers(list1, list2);
            Assert.That(RetrieveOverallValue(result), Is.EqualTo(100000998));
        }
    }
}
