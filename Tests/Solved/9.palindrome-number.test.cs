namespace palindromenumber
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
            bool result = solution.IsPalindrome(9);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void case2()
        {
            bool result = solution.IsPalindrome(161);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void case3()
        {
            bool result = solution.IsPalindrome(10);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void case4()
        {
            bool result = solution.IsPalindrome(-101);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void case5()
        {
            bool result = solution.IsPalindrome(101010101);
            Assert.That(result, Is.EqualTo(true));
        }

        [Test]
        public void case6()
        {
            bool result = solution.IsPalindrome(1010101010);
            Assert.That(result, Is.EqualTo(false));
        }

        [Test]
        public void case7()
        {
            bool result = solution.IsPalindrome(16216);
            Assert.That(result, Is.EqualTo(false));
        }
    }
}
