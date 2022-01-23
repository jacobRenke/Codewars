using System;

public static class Kata
{
    public static string Solution(string str)
    {
        string rev = "";
        for (int c = str.Length; c > 0; c--)
        {

            rev += str[c - 1];
        }
        return rev;
    }
}