namespace AddBinary
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
            string result = solution.AddBinary("10", "1");
            Assert.That(result, Is.EqualTo("11"));
        }

        [Test]
        public void Case2()
        {
            string result = solution.AddBinary("1000", "1");
            Assert.That(result, Is.EqualTo("1001"));
        }

        [Test]
        public void Case3()
        {
            string result = solution.AddBinary("11", "1");
            Assert.That(result, Is.EqualTo("100"));
        }

        [Test]
        public void Case4()
        {
            string result = solution.AddBinary("111", "111");
            Assert.That(result, Is.EqualTo("1110"));
        }

        [Test]
        public void Case5()
        {
            string result = solution.AddBinary("101", "111");
            Assert.That(result, Is.EqualTo("1100"));
        }
    }
}
