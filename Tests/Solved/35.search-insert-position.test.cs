namespace SearchInsertPosition
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
        public void Case1()
        {
            int result = solution.SearchInsert([1, 2, 3, 4, 5, 6, 7], 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Case2()
        {
            int result = solution.SearchInsert([1, 3, 4, 5, 6, 7], 2);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Case3()
        {
            int result = solution.SearchInsert([1, 2, 3, 4, 5, 6, 7], 8);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Case4()
        {
            int result = solution.SearchInsert([1, 2, 3, 4, 5, 6, 7], -5);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
