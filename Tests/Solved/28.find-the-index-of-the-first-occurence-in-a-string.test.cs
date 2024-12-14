namespace FindTheIndexOfTheFirstOccurrenceInAString
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
            int result = solution.StrStr("abchalloabc", "hallo");
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case2()
        {
            int result = solution.StrStr("aklsjdqwe", "hallo");
            Assert.That(result, Is.EqualTo(-1));
        }

        [Test]
        public void Case3()
        {
            int result = solution.StrStr("abcdehalloabchalloabc", "hallo");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Case4()
        {
            int result = solution.StrStr("x", "x");
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Case5()
        {
            int result = solution.StrStr("x", "y");
            Assert.That(result, Is.EqualTo(-1));
        }
    }
}
