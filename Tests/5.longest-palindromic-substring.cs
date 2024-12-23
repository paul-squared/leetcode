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
    public void SubCase1()
    {
        bool result = Solution.IsPalindrome("a");
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void SubCase2()
    {
        bool result = Solution.IsPalindrome("ab");
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void SubCase3()
    {
        bool result = Solution.IsPalindrome("abcdefgfedcba");
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void SubCase4()
    {
        bool result = Solution.IsPalindrome("abba");
        Assert.That(result, Is.EqualTo(true));
    }

    [Test]
    public void SubCase5()
    {
        bool result = Solution.IsPalindrome("abcdefgabcdefg");
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void SubCase6()
    {
        bool result = Solution.IsPalindrome("abcabcabcabc");
        Assert.That(result, Is.EqualTo(false));
    }

    [Test]
    public void Case1()
    {
        string result = solution.LongestPalindrome("a");
        Assert.That(result, Is.EqualTo("a"));
    }

    [Test]
    public void Case2()
    {
        string result = solution.LongestPalindrome("aba");
        Assert.That(result, Is.EqualTo("aba"));
    }

    [Test]
    public void Case3()
    {
        string result = solution.LongestPalindrome("abba");
        Assert.That(result, Is.EqualTo("abba"));
    }

    [Test]
    public void Case4()
    {
        string result = solution.LongestPalindrome("aabbbaa");
        Assert.That(result, Is.EqualTo("aabbbaa"));
    }

    [Test]
    public void Case5()
    {
        string result = solution.LongestPalindrome("aabbbaaa");
        Assert.That(result, Is.EqualTo("aabbbaa"));
    }

    [Test]
    public void Case6()
    {
        string result = solution.LongestPalindrome("abcabacba");
        Assert.That(result, Is.EqualTo("abcabacba"));
    }

    [Test]
    public void Case7()
    {
        string result = solution.LongestPalindrome("xyabcabacba");
        Assert.That(result, Is.EqualTo("abcabacba"));
    }

    [Test]
    public void Case8()
    {
        string result = solution.LongestPalindrome("xyabcabacbaabc");
        Assert.That(result, Is.EqualTo("abcabacba"));
    }
}
