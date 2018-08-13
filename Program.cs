/*
Sort a String from Coding Challenges
by Silvio Duka

Last modified date: 2018-03-12

Given a string as input, output its characters alphabetically sorted from A to Z. 
For Example: 
Input: challenge 
Output: aceeghlln 

Number should go first: 
Input: happy42 
Output: 24ahppy 

Special characters, such as symbols, go before numbers and letters: 
Input: $tar3 
Output: $3art 

Whitespaces should be ignored. 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SortAString
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "happy42"; // Insert a string to sort it's characters alphabetically

            Console.WriteLine($"Input: {input}");
            Console.WriteLine($"Output: {SortAString(input)}");
        }

        static string SortAString(string s)
        {
            char[] chars = (Regex.Replace(s, @"\s+", "")).ToLower().ToCharArray(); //Remove all white-spaces, convert string to lowercase and to char array. 

            for (int i = 0; i < chars.Length - 1; i++)
            {
                for (int j = 0; j < chars.Length - 1 - i; j++)
                {
                    if (chars[j] > chars[j + 1])
                    {
                        char t = chars[j];
                        chars[j] = chars[j + 1];
                        chars[j + 1] = t;
                    }
                }
            }
            
            //Array.Sort(chars); // Shorter but less demanding way... :-D 

            return new string(chars);
        }
    }
}
