using System;

public static class Kata
{
    public static string Disemvowel(string str)
    {
      
      char[] arr = str.ToCharArray();
      
      foreach (char c in arr)
      {
        arr.Remove("a", "e", "i", "o", "u");
      }
        return str;
    }
}