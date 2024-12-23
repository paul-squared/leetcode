namespace LengthOfLongestSubstring {
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
            int result = solution.LengthOfLongestSubstring("abcabcbb");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case2()
        {
            int result = solution.LengthOfLongestSubstring("bbbbb");
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Case3()
        {
            int result = solution.LengthOfLongestSubstring("pwwkew");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case4()
        {
            int result = solution.LengthOfLongestSubstring("au");
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Case5()
        {
            int result = solution.LengthOfLongestSubstring("aab");
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Case6()
        {
            int result = solution.LengthOfLongestSubstring("dvdf");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case7()
        {
            int result = solution.LengthOfLongestSubstring("ckilbkd");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Case8()
        {
            int result = solution.LengthOfLongestSubstring("tmmzuxt");
            Assert.That(result, Is.EqualTo(5));
        }
    }
}