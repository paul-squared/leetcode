namespace ClimbStairs
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
            int result = solution.ClimbStairs(1);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Case2()
        {
            int result = solution.ClimbStairs(2);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Case3()
        {
            int result = solution.ClimbStairs(3);
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Case4()
        {
            int result = solution.ClimbStairs(4);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Case5()
        {
            int result = solution.ClimbStairs(5);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void Case6()
        {
            int result = solution.ClimbStairs(6);
            Assert.That(result, Is.EqualTo(13));
        }
    }
}
