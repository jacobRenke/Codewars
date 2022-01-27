using System;
using System.Collections.Generic;

namespace Highest_Scoring_Word
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string TestCaseData = "aa b";
            High(TestCaseData);
        }

        public static string High(string s)
        {
            s = s.ToLower();

            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Dictionary<char, int> letterValues = new Dictionary<char, int>();
            for (int i = 0; i < alphabet.Length; i++)
            {
                letterValues.Add(alphabet[i], i + 1); //gives us our a = 1, b = 2,... values into our dictionary
            }

            string[] split = s.Split(' ');

            // Holds index of current highest scoring word
            int highestWord = 0;
            // Holds value of current highest scoring word
            int highestWordVal = 0;
            // Holds value of word being scored/compared
            int tempVal = 0;
            // Holds word being scored
            string tempWord = "";

            for (int j = 0; j < split.Length; j++)
            {
                // Iterates through string array "split" (i.e., each word)
                tempWord = split[j];

                for (int i = 0; i < tempWord.Length; i++)
                {
                    // Iterates through letters of word currently selected by previous for loop
                    // Assigns word value/score to tempVal variable
                    tempVal += letterValues[tempWord[i]];
                    highestWord = Array.IndexOf(split, tempWord);
                    // Compare tempValue to highestWordVal to determine new highest value
                    // Assign index of highest valued word to highestWord for return
                    if (highestWordVal < tempVal && highestWordVal != tempVal)
                    {
                        highestWordVal = tempVal;
                        highestWord = Array.IndexOf(split, tempWord);
                    }
                }
            }
            if (split.Length <= 2)
            {
                return split[highestWord - 1];
            }
            else
            {
                return split[highestWord];
            }
        }
    }
}


//Given a string of words, you need to find the highest scoring word.

//Each letter of a word scores points according to its position in the alphabet: a = 1, b = 2, c = 3 etc.

//You need to return the highest scoring word as a string.

//If two words score the same, return the word that appears earliest in the original string.

//All letters will be lowercase and all inputs will be valid.
