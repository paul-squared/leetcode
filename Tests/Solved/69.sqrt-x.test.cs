namespace MySqrt
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
            int result = solution.MySqrt(4);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Case2()
        {
            int result = solution.MySqrt(9);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case3()
        {
            int result = solution.MySqrt(16);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Case4()
        {
            int result = solution.MySqrt(55);
            Assert.That(result, Is.EqualTo(7));
        }

        [Test]
        public void Case5()
        {
            int result = solution.MySqrt(1234567);
            Assert.That(result, Is.EqualTo(1111));
        }

        [Test]
        public void Case6()
        {
            int result = solution.MySqrt(1234321);
            Assert.That(result, Is.EqualTo(1111));
        }

        [Test]
        public void Case7()
        {
            int result = solution.MySqrt(3);
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
