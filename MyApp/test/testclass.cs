using Xunit;
using static palindromecheck.Program;
 public class testclass
 {
  [Fact]
  public void isPalindromeTest()
  {
      Assert.True(isPalindrome("racecar"));
  }

  [Fact]
  public void notIsPalindromeTest()
  {
      Assert.False(isPalindrome("racecars"));
  }

  [Theory]
  [InlineData("abba")]
  [InlineData("aaaaaa")]
  [InlineData("asdfer")]
  [InlineData("holaaaaa")]
  public void multipleTests(String s)
  {
      Assert.True(isPalindrome(s));
  }
 }