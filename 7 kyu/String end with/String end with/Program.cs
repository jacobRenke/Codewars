using System;
using System.Collections.Generic;

namespace String_end_with
{
    internal class Program
    {
        public static void Main(){
        Console.WriteLine(Solution("Fart", "art"));
        Console.WriteLine(Solution("Cinnamon", "n"));
        Console.WriteLine(Solution("Ribosome", "ygfdsgdfghdsfgdsfgdsfg"));
        }
        

        public static bool Solution(string str, string ending)
        {
            if (str.Length >= ending.Length)
            {
                int diff = str.Length - ending.Length;
                string firstWord = str.Substring(diff, ending.Length);
                string secondWord = ending.Substring(0, ending.Length);
                if (firstWord == secondWord)
                {
                    return true;
                }
            }
            return false;
        }
    }

}



//Complete the solution so that it returns true if the first argument(string) passed in ends with the 2nd argument (also a string).

//Examples:

//solution('abc', 'bc') // returns true
//solution('abc', 'd') // returns false