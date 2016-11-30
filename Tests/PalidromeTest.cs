using Xunit;
using System;
using System.Collections.Generic;
using PalindromeChecker.Objects;

namespace  PalindromeChecker
{
  public class PalindromeTest
  {
    [Fact]
    public void IsPalindrome_ReverseWord_true()
    {
      //Arrange
      string word = "Taco cat";
      Palindrome newPalindrome = new Palindrome(word);
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.IsPalindrome());
    }
    [Fact]
    public void IsPalindrome_RemoveSpaces_true()
    {
      //Arrange
      string word = "Taco cat";
      Palindrome newPalindrome = new Palindrome(word);
      //Act
      //Assert
      Assert.Equal(true, newPalindrome.IsPalindrome());
    }
  }
}
