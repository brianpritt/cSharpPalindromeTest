using Nancy;
using System.Collections.Generic;
using System;
using PalindromeChecker.Objects;

namespace PalindromeChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/result"] = _ => {
        Palindrome myPalindrome = new Palindrome(Request.Form["string"]);
        bool isPalindrome = myPalindrome.IsPalindrome();
        myPalindrome.Truthy = isPalindrome;
        return View["results.cshtml",myPalindrome];
      };

    }
  }
}
