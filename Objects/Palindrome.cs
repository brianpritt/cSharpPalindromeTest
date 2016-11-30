using System;
using System.Collections.Generic;

namespace PalindromeChecker.Objects
{
  public class Palindrome
  {
    public string Word {get; set;}

    public Palindrome(string word)
    {
      this.Word = word;
    }
    public string IsPalindrome()
    {
      char[] wordArray = this.Word.ToCharArray();
      Array.Reverse(wordArray);
      string reverseWord =new string(wordArray);
      Console.WriteLine(reverseWord);
      return reverseWord;
    }
  }
}
