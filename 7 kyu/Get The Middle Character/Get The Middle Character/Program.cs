using System;

namespace Get_The_Middle_Character
{
    public class Kata
    {
        public static string GetMiddle(string s)
        {
            char[] ch = s.ToCharArray();

            if (ch.Length % 2 == 0)
            {
                return ($"{ch[(ch.Length - 1) / 2]}{ch[(ch.Length - 1) / 2 + 1]}");
            }
            else
            {
                return ($"{ch[(ch.Length - 1) / 2]}");
            }
        }
    }
}


//#Input

//A word(string) of length 0 < str < 1000 (In javascript you may get slightly more than 1000 in some test cases due to an error in the test cases).
//You do not need to test for this.This is only here to tell you that you do not need to worry about your solution timing out.

//#Output

//The middle character(s) of the word represented as a string.
