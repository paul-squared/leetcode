namespace twosums
{
    [TestFixture]
    public class SolutionTests
    {
        private Solution solution;

        [SetUp]
        protected void Setup()
        {
            solution = new Solution();
        }

        [Test]
        public void TestTwoSum_Case1()
        {
            int[] result = solution.TwoSum([2, 7, 11, 15], 9);
            Assert.Multiple(() =>
            {
                Assert.That(result, Has.Member(0));
                Assert.That(result, Has.Member(1));
            });
        }

        [Test]
        public void TestTwoSum_Case2()
        {
            int[] result = solution.TwoSum([3, 2, 4], 6);
            Assert.Multiple(() =>
            {
                Assert.That(result, Has.Member(1));
                Assert.That(result, Has.Member(2));
            });
        }

        [Test]
        public void TestTwoSum_Case3()
        {
            int[] result = solution.TwoSum([3, 3], 6);
            Assert.Multiple(() =>
            {
                Assert.That(result, Has.Member(0));
                Assert.That(result, Has.Member(1));
            });
        }
    }
}
