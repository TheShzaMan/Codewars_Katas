using System;
using System.Collections.Generic;

namespace PracticeAndRetraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Function that takes in a number with an unknown number of digits and
            ////      returns an array of that number's digits but reversed.
            ////      ex. (input => output):  65432 => [2,3,4,5,6] 
            //static int[] Digitize(long n)
            //{
            //    string numAsString = n.ToString();
            //    int[] numberAsArray = new int[numAsString.Length];
            //    int[] reversedArray = new int[numAsString.Length];
            //    int numCount = numAsString.Length;


            //    for (int i = 0; i < numCount; i++)                
            //    {
            //        reversedArray[i] = int.Parse(numAsString[numCount - 1 - i].ToString());
            //        Console.WriteLine(reversedArray[i]); 
            //    }
            //    return reversedArray;
            //}

            //long myNumber = 65432;

            //Digitize(myNumber);

            /////////////////////////////////////////////
            ///
            // Function that takes in an integer, squares each digit, concatenates
            //  the result into one and returns an integer
            static int SquareDigits(int n)
            {
                var stringN = n.ToString();
                List<int> digits = new();

                foreach (var charDigit in stringN)
                {
                    int digit = (int)charDigit - '0';
                    digits.Add(digit * digit);
                }

                return Convert.ToInt32(string.Join("", digits));
            }

            int example = 9119;

            SquareDigits(example);

            /////////////////////////////////////////////
            ///
            // Function to check if word is an isogram by taking in a string of letters, checking for
            //  repeating letters, if none returning true, otherwise returning false

        }
    }
}