using System;
using System.Collections.Generic;

namespace PracticeAndRetraining
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Function that takes in a number with an unknown number of digits and
            ////  returns an array of that number's digits but reversed.
            ////  ex. (input => output):  65432 => [2,3,4,5,6]
            //
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
            //// Function that takes in an integer, squares each digit, concatenates
            ////  the result into one and returns an integer.
            //
            //static int SquareDigits(int n)
            //{
            //    var stringN = n.ToString();
            //    List<int> digits = new();

            //    foreach (var charDigit in stringN)
            //    {
            //        int digit = (int)charDigit - '0';
            //        digits.Add(digit * digit);
            //    }

            //    return Convert.ToInt32(string.Join("", digits));
            //}

            //int example = 9119;

            //SquareDigits(example);

            /////////////////////////////////////////////
            ///
            // Function to check if word is an isogram by taking in a string of letters, checking for
            //  repeating letters, ignoring letter case (ie. lowerCase = upperCase), if none returning true,
            //  otherwise returning false.
            //
            //static bool IsIsogram(string str)
            //{
            //    bool isIsogram = true;
            //    str = str.ToLower();

            //    foreach (char s in str)
            //    {
            //        string modStr = str.Remove(str.IndexOf(s), 1);                    
            //        if (modStr.Contains(s))
            //        {
            //            isIsogram = false;  break;
            //        }
            //    }

            //    return isIsogram;
            //}

            //IsIsogram("Dermatoglyphics"); //true
            //IsIsogram("isogram");         //true
            //IsIsogram("moose");           //false
            //IsIsogram("moOse");           //false

            /////////////////////////////////////////////
            ///
            // Function that takes in a positive parameter num and returns its multiplicative persistence, which
            // is the number of times you must multiply the digits in num until you reach a single digit.
            // ex. (Input --> Output)
            //        39  --> 3  (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)

            static int Persistence(long n)
            {
                var nAsArray = n.ToString().ToArray();
                
                while (nAsArray.Length > 1)
                {
                    var tempResult = 1;
                    for (int i = 0; i < nAsArray.Length - 1; i++)
                    {
                        tempResult *= (int)( nAsArray[i] - '0');                        
                    }
                    nAsArray = tempResult.ToString().ToArray();                    
                }

                int result = nAsArray[0]; 
                Console.WriteLine(result);
                return result;
            }
            Persistence(999); //should return 4
        }
    }
}