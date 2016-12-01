using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PalindromeChecker.Objects
{
  public class Palindrome
  {
    public string Word {get; set;}
    public bool Truthy {get; set;}

    public Palindrome(string word, bool truthy = false)
    {
      this.Word = word;
      this.Truthy = truthy;

    }
    public bool IsPalindrome()
    {
      string newWord = this.Word.Replace(" ", "");
      //regEx
      string pattern = "\\W";
      string replacement = "";
      Regex rgx = new Regex(pattern);
      string cleanWord = rgx.Replace(newWord,replacement);
      //end regEx
      char[] wordArray = cleanWord.ToCharArray();
      Array.Reverse(wordArray);
      string reverseWord =new string(wordArray);
      if (cleanWord.ToLower() == reverseWord.ToLower())
      {
        return true;
      }
      return false;
    }
  }
}
