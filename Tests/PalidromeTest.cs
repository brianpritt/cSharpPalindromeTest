using Xunit;
using System;
using System.Collections.Generic;
using PalindromeChecker.Objects;

namespace  PalindromeChecker
{
  public class PalindromeTest
  {
    [Fact]
    public void IsPalindromeReverseWord_true()
    {
      //Arrange
      string word = "Dog";
      Palindrome newPalindrome = new Palindrome(word);
      //Act
      //Assert
      Assert.Equal("goD", newPalindrome.IsPalindrome());
    }
  }
}
