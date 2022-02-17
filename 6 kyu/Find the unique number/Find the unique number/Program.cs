using System;
using System.Collections.Generic;
using System.Linq;

namespace Find_the_unique_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 2, 2 };
            Console.WriteLine(GetUnique(arr));
        }

        public static int GetUnique(IEnumerable<int> numbers)
        {
            int[] findNumber = numbers.ToArray<int>();
            Array.Sort(findNumber);
            int answer = 0;

            for (int i = 0; i < findNumber.Length - 1; i++)
            {
                for (int j = 0; j < findNumber.Length; j++)
                {
                    if (findNumber[i] != findNumber[j])
                    {
                        answer = findNumber[j];
                    }
                }
            }
            return answer; 
        }


    }
}
