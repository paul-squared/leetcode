namespace Convert
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
            string result = solution.Convert("abcdefghijklmnopqrstuvwxyz", 1);
            Assert.That(result, Is.EqualTo("abcdefghijklmnopqrstuvwxyz"));
        }

        [Test]
        public void Case2()
        {
            string result = solution.Convert("abcdefghijklmnopqrstuvwxyz", 2);
            Assert.That(result, Is.EqualTo("acegikmoqsuwybdfhjlnprtvxz"));
        }

        [Test]
        public void Case3()
        {
            string result = solution.Convert("abcdefghijklmnopqrstuvwxyz", 3);
            Assert.That(result, Is.EqualTo("aeimquybdfhjlnprtvxzcgkosw"));
        }

        [Test]
        public void Case4()
        {
            string result = solution.Convert("abcdefghijklmnopqrstuvwxyz", 4);
            Assert.That(result, Is.EqualTo("agmsybfhlnrtxzceikoquwdjpv"));
        }

        [Test]
        public void Case5()
        {
            string result = solution.Convert("abcdefghijklmnopqrstuvwxyz", 5);
            Assert.That(result, Is.EqualTo("aiqybhjprxzcgkoswdflntvemu"));
        }
    }
}
