using Xunit;
using System;
using System.Collections.Generic;
using Palindrome.Objects;

namespace  PalindromeChecker
{
  public class PalindromeTest
  {
    [Fact]
    public void IsPalindromeReverseWord_true()
    {
      //Arrange
      string word = "racecar";
      //Act
      //Assert
      Assert.Equal(true, TEMPLATE);
    }
  }
}
