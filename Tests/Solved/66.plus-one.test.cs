namespace PlusOne
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
            int[] result = solution.PlusOne([1, 2, 3, 4]);
            int[] expected = [1, 2, 3, 5];
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Case2()
        {
            int[] result = solution.PlusOne([1, 2, 3, 9]);
            int[] expected = [1, 2, 4, 0];
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Case3()
        {
            int[] result = solution.PlusOne([1, 2, 9, 0]);
            int[] expected = [1, 2, 9, 1];
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Case4()
        {
            int[] result = solution.PlusOne([1, 9, 3, 9]);
            int[] expected = [1, 9, 4, 0];
            CollectionAssert.AreEqual(result, expected);
        }

        [Test]
        public void Case5()
        {
            int[] result = solution.PlusOne([9, 9, 9, 9]);
            int[] expected = [1, 0, 0, 0, 0];
            CollectionAssert.AreEqual(result, expected);
        }
    }
}
