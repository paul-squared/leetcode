namespace validParentheses
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
            bool result = solution.IsValid("((({{{{{{{{[[[[({(())})]]]]}}}}}}}})))");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Case2()
        {
            bool result = solution.IsValid("{[()]}()[]{}");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Case3()
        {
            bool result = solution.IsValid("{[]{({})}}");
            Assert.That(result, Is.True);
        }

        [Test]
        public void Case4()
        {
            bool result = solution.IsValid("(){}[[}]]");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Case5()
        {
            bool result = solution.IsValid("(");
            Assert.That(result, Is.False);
        }

        [Test]
        public void Case6()
        {
            bool result = solution.IsValid("]");
            Assert.That(result, Is.False);
        }
    }
}
