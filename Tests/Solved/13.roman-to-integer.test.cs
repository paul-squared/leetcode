namespace romantointeger
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
        public void case1()
        {
            int result = solution.RomanToInt("V");
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void case2()
        {
            int result = solution.RomanToInt("M");
            Assert.That(result, Is.EqualTo(1000));
        }

        [Test]
        public void case3()
        {
            int result = solution.RomanToInt("IX");
            Assert.That(result, Is.EqualTo(9));
        }

        [Test]
        public void case4()
        {
            int result = solution.RomanToInt("LVIII");
            Assert.That(result, Is.EqualTo(58));
        }

        [Test]
        public void case5()
        {
            int result = solution.RomanToInt("MCMXCIV");
            Assert.That(result, Is.EqualTo(1994));
        }
    }
}
