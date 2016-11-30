using System;
using System.Collections.Generic;

namespace PalindromeChecker.Objects
{
  public class Palindrome
  {
    public string Word {get; set;}
    private List<string> TEMPLATE = new List<string> {};

    public Palindrome(word)
    {
      this.Word = word;
    }
    public string IsPalindrome()
    {
      char[] wordArray = this.Word.ToCharArray()
      Array.ReverseArray(wordArray);
    }
  }
}
