namespace LengthOfLastWord
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
            int result = solution.LengthOfLastWord("Eins zwei drei vier");
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Case2()
        {
            int result = solution.LengthOfLastWord("Eins zwei drei vier     ");
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Case3()
        {
            int result = solution.LengthOfLastWord("vier");
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Case4()
        {
            int result = solution.LengthOfLastWord(
                "Eins zwei drei             vier                "
            );
            Assert.That(result, Is.EqualTo(4));
        }

        [Test]
        public void Case5()
        {
            int result = solution.LengthOfLastWord("v");
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
