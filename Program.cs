using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks.Dataflow;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata.Ecma335;

namespace PracticeAndRetraining
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////
            ////
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
            ////
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
            ////
            //// Function to check if word is an isogram by taking in a string of letters, checking for
            ////  repeating letters, ignoring letter case (ie. lowerCase = upperCase), if none returning true,
            ////  otherwise returning false.
            ////
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
            ////
            //// Function that takes in a positive parameter num and returns its multiplicative persistence, which
            //// is the number of times you must multiply the digits in num until you reach a single digit.
            //// ex. (Input --> Output)
            ////        39  --> 3  (because 3*9 = 27, 2*7 = 14, 1*4 = 4 and 4 has only one digit)
            //static int Persistence(long n)
            //{
            //    var nAsArray = n.ToString();
            //    int loopCount = 0;

            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();

            //    while (nAsArray.Length > 1)
            //    {
            //        var tempResult = 1; //variable to hold the result of each multiplication as it rolls through all the digits
            //        for (int i = 0; i < nAsArray.Length; i++)
            //        {                        
            //            //tempResult *= Int32.Parse( nAsArray[i].ToString());
            //            tempResult *= (int)(nAsArray[i] - '0'); //much faster than the .Parse conversion method
            //        }
            //        nAsArray = tempResult.ToString(); //make result the new array to check
            //        loopCount++;
            //    }

            //    stopwatch.Stop();
            //    Console.WriteLine(loopCount);

            //    int result = loopCount;
            //    return result;
            //}
            //Persistence(999); //should return 4

            ///////////////////////////////////////////////
            ////
            ////  function that accepts a string parameter, and reverses each word in the string.
            ////  All spaces in the string should be retained.
            //// ex. "double  spaces" ==> "elbuod  secaps"
            //static string ReverseWords(string str)
            //{
            //    string[] words = str.Split(' ');
            //    string[] reversedWords = new string[words.Length];  

            //    for (int i = 0; i < words.Length; i++)
            //    {
            //        var tempWord = words[i].ToCharArray();
            //        Array.Reverse(tempWord);
            //        reversedWords[i] = new string(tempWord);
            //    }
            //    Console.WriteLine(String.Join(" ", reversedWords));
            //    return String.Join(" ", reversedWords);
            //}
            //ReverseWords("This is an example!");

            /////////////////////////////////////////////
            /////
            //// Given a square matrix, a 2D array, calculate the absolute difference between the sums of its diagonals.
            //// ex. [[1,2,3], [4,5,6], [9,8,9]]  would be the difference between the sum of 1, 5, 9 and 3, 5, 9 and would return int 2
            //static int diagonalDifference(List<List<int>> arr)
            //{
            //    int n = arr.Count();
            //    int[] primary = new int[n];
            //    int[] secondary = new int[n];
            //    int result;

            //    for (int i = 0; i < n; i++)
            //    {
            //        primary[i] = arr[i][i];
            //        secondary[i] = arr[i][arr[i].Count() - 1 - i];
            //    }
            //    int primarySum = primary.Sum();
            //    int secondarySum = secondary.Sum();

            //    if (primarySum > secondarySum)
            //    {
            //        return result = primarySum - secondarySum;
            //    }
            //    else
            //    {
            //        return result = secondarySum - primarySum;
            //    }
            //    /return result;
            //}

            ////\\//// User interface to collect data needed to create ParamArray() parameter

            //Console.WriteLine("Enter number of rows: ");
            //int n = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Enter rows, each with {n} numbers, separated by a space, numbers must be in the range -100 to 100:");

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList()
            //    .Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //Console.WriteLine(diagonalDifference(arr));

            /////////////////////////////////////////////
            /////
            ////  function that takes an integer as input, and returns the number of bits that are equal to one in the 
            ////     binary representation of that number.

            //static int CountBits(int n)
            //{
            //    string asBinary = Convert.ToString(n, 2);
            //    List<int> asIntArr = new List<int>();
            //    foreach (char c in asBinary)
            //    {
            //        if (c == '1')
            //        {
            //            asIntArr.Add(c);
            //            continue;
            //        }
            //        else
            //        {
            //            continue;
            //        }
            //    }
            //    Console.WriteLine(asIntArr.Count);
            //    int result = asIntArr.Count;
            //    return result;
            //}

            //CountBits(42);

            /////////////////////////////////////////////
            /////
            ////  Create a function taking a positive integer between 1 and 3999 (both included) 
            ////    as its parameter and returning a string containing the Roman Numeral 
            ////    representation of that integer.

            //static string Solution(int n)
            //{
            //    Dictionary<int, string> romanMap = new Dictionary<int, string>()
            //    {
            //        {1000,"M"}, {900, "CM"}, {500, "D"}, {400, "CD"}, {100,"C"}, {90, "XC"}, {50, "L"}, {40, "XL"}, {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"}, {1, "I"}
            //    };

            //    List<string> inRoman = new();
            //    int number = n;

            //   foreach (var roman in romanMap)
            //    {
            //        while (number / roman.Key >= 1)
            //        {
            //            inRoman.Add(roman.Value);
            //            number -= roman.Key;                       
            //        }
            //    }
            //    Console.WriteLine(string.Join("", inRoman));
            //    string romanConversion = (string.Join("", inRoman));


            //    return romanConversion;
            //}
            //Solution(1666);

            /////////////////////////////////////////////
            /////
            //// function that takes an array of ints and a target number. It should find two 
            ///     different items in the array that, when added together, give the target value. 
            ///     The indices of these items should then be returned in a tuple / list like so: (index1, index2)
            //static int[] TwoSum(int[] numbers, int target)
            //{
            //    int[] indices = new int[2];


            //    for (int i = 0; i < numbers.Length; i++)
            //    {

            //        if (numbers.Contains(target - numbers[i]) &&
            //            i != Array.IndexOf(numbers, (target - numbers[i])))
            //        {
            //            indices[0] = i;
            //            indices[1] = Array.IndexOf(numbers, (target - numbers[i]));
            //            Console.WriteLine(string.Join(", ", indices));
            //            return indices;
            //        }

            //    }

            //    return indices;
            //}
            //TwoSum(new[] { 3,2,4 }, 6);

            /////////////////////////////////////////////
            /////
            //// Implement a difference function, which subtracts one list from another and returns the result.
            ///    It should remove all values from list a, which are present in list b keeping their order.
            ///    ex. Kata.ArrayDiff(new int[] {1, 2, 2, 2, 3}, new int[] {2}) => new int[] {1, 3}
            static int[] ArrayDiff(int[] a, int[] b)
            {
               // List<int> listToCheck = a.ToList();
                List<int> resultList = a.ToList();

                if (b.Length == 0) return a;

                foreach(int element in b)
                {
                    resultList = resultList
                        .Where(x => x != element).ToList();
                }

                Console.WriteLine(String.Join(", ", resultList));
                return resultList.ToArray();
            }

           // ArrayDiff(new int[] { 1, 2, 2, 2, 3 }, new int[] { 2 });
            //ArrayDiff(new int[] { 1, 2, 2 }, new int[] { });
            ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 });

        }
    }
}