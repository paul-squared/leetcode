namespace longestCommonPrefix
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
            string result = solution.LongestCommonPrefix(["defabc", "abc", "abcghi"]);
            Assert.That(string.IsNullOrEmpty(result), Is.True);
        }

        [Test]
        public void Case2()
        {
            string result = solution.LongestCommonPrefix(["flower", "flonk", "floflofloxxx"]);
            Assert.That(result, Is.EqualTo("flo"));
        }

        [Test]
        public void Case3()
        {
            string result = solution.LongestCommonPrefix(["abcdefg", "abcdefg", "abcdefg"]);
            Assert.That(result, Is.EqualTo("abcdefg"));
        }

        [Test]
        public void Case4()
        {
            string result = solution.LongestCommonPrefix(
                ["qwertzuiop", "qxwertzuiop", "qwertzuiop"]
            );
            Assert.That(result, Is.EqualTo("q"));
        }

        [Test]
        public void Case5()
        {
            string result = solution.LongestCommonPrefix(["flower", "flow", "flight"]);
            Assert.That(result, Is.EqualTo("fl"));
        }

        [Test]
        public void Case6()
        {
            string result = solution.LongestCommonPrefix(["flow", "", "flight"]);
            Assert.That(string.IsNullOrEmpty(result), Is.True);
        }

        [Test]
        public void Case7()
        {
            string result = solution.LongestCommonPrefix([""]);
            Assert.That(string.IsNullOrEmpty(result), Is.True);
        }

        [Test]
        public void Case8()
        {
            string result = solution.LongestCommonPrefix(["abcgasd", "abcdef"]);
            Assert.That(result, Is.EqualTo("abc"));
        }
    }
}
