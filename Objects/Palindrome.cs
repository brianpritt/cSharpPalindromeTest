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
    public bool IsPalindrome()
    {
      string newWord = this.Word.Replace(" ", "");
      char[] wordArray = newWord.ToCharArray();
      Array.Reverse(wordArray);
      string reverseWord =new string(wordArray);
      Console.WriteLine(reverseWord.ToLower());
      Console.WriteLine(newWord.ToLower());

      if (newWord.ToLower() == reverseWord.ToLower())
      {
        return true;
      }
      return false;
    }
  }
}
