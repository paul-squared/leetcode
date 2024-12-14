namespace RemoveElement
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

        protected static bool ValidateNums(int result, int[] nums, int[] expected)
        {
            Assert.That(result, Is.EqualTo(expected.Length));
            int[] numsSubset = new int[result];
            Array.Copy(nums, numsSubset, result);
            Array.Sort(numsSubset);
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(numsSubset[i], Is.EqualTo(expected[i]));
            }
            return true;
        }

        [Test]
        public void Case1()
        {
            int val = 1;
            int[] nums = [1, 1, 2, 2, 3, 3, 4, 4];
            int[] expectedNums = [2, 2, 3, 3, 4, 4];
            int result = solution.RemoveElement(nums, val);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case2()
        {
            int val = 5;
            int[] nums = [5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5];
            int[] expectedNums = [];
            int result = solution.RemoveElement(nums, val);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case3()
        {
            int val = 2;
            int[] nums = [15, 3, 88, 2, 97, 15, 2];
            int[] expectedNums = [3, 15, 15, 88, 97];
            int result = solution.RemoveElement(nums, val);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case4()
        {
            int val = 99;
            int[] nums = [1, 2, 3, 4];
            int[] expectedNums = [1, 2, 3, 4];
            int result = solution.RemoveElement(nums, val);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }
    }
}
