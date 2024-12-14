namespace RemoveDuplicatesFromSortedArray
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
            for (int i = 0; i < expected.Length; i++)
            {
                Assert.That(nums[i], Is.EqualTo(expected[i]));
            }
            return true;
        }

        [Test]
        public void Case1()
        {
            int[] nums = [1, 1, 2, 2, 3, 3, 4, 4];
            int[] expectedNums = [1, 2, 3, 4];
            int result = solution.RemoveDuplicates(nums);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case2()
        {
            int[] nums = [99, 101, 9888];
            int[] expectedNums = [99, 101, 9888];
            int result = solution.RemoveDuplicates(nums);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case3()
        {
            int[] nums = [5];
            int[] expectedNums = [5];
            int result = solution.RemoveDuplicates(nums);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }

        [Test]
        public void Case4()
        {
            int[] nums = [5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5];
            int[] expectedNums = [5];
            int result = solution.RemoveDuplicates(nums);
            Assert.That(ValidateNums(result, nums, expectedNums), Is.True);
        }
    }
}
