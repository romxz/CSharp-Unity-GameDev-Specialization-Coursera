using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionBinarySearch
{
    /// <remarks>
    /// Demonstrates binary search using recursion
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Accomplish various binary searches using recursion
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            DoEvenBinarySearch();
            DoOddBinarySearch();
        }

        /// <summary>
        /// Performs binary searches of an even-sized array
        /// </summary>
        static void DoEvenBinarySearch()
        {
            int[] searchArray = { 1, 3, 5, 12, 17, 21, 33, 42, 42, 42 };

            Console.WriteLine("Even array, value in array");
            int result = BinarySearch(3, searchArray, 0, searchArray.Length - 1);
            if (result != -1)
            {
                Console.WriteLine("Found value at " + result);
            }
            else
            {
                Console.WriteLine("Didn't find value");
            }
            Console.WriteLine();

            Console.WriteLine("Even array, value not in array");
            result = BinarySearch(43, searchArray, 0, searchArray.Length - 1);
            if (result != -1)
            {
                Console.WriteLine("Found value at " + result);
            }
            else
            {
                Console.WriteLine("Didn't find value");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Performs binary searches of an odd-sized array
        /// </summary>
        static void DoOddBinarySearch()
        {
            int[] searchArray = { 1, 3, 5, 12, 17, 21, 33, 42, 42, 42, 42 };

            Console.WriteLine("Odd array, value in array");
            int result = BinarySearch(3, searchArray, 0, searchArray.Length - 1);
            if (result != -1)
            {
                Console.WriteLine("Found value at " + result);
            }
            else
            {
                Console.WriteLine("Didn't find value");
            }
            Console.WriteLine();

            Console.WriteLine("Odd array, value not in array");
            result = BinarySearch(43, searchArray, 0, searchArray.Length - 1);
            if (result != -1)
            {
                Console.WriteLine("Found value at " + result);
            }
            else
            {
                Console.WriteLine("Didn't find value");
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Performs a binary search for the given value
        /// </summary>
        /// <param name="searchValue">the value to search for</param>
        /// <param name="searchArray">the array to search</param>
        /// <param name="lowerBound">the lower bound index to use for the search</param>
        /// <param name="upperBound">the upper bound index to use for the search</param>
        /// <returns>true if the value is found, false otherwise</returns>
        static int BinarySearch(int searchValue, int[] searchArray, int lowerBound, int upperBound)
        {
            // check exhausted array termination condition
            if (lowerBound > upperBound)
            {
                return -1;
            }

            // check found value termination condition
            int middleLocation = lowerBound + (upperBound - lowerBound) / 2;
            int middleValue = searchArray[middleLocation];
            if (middleValue == searchValue)
            {
                return middleLocation;
            }

            // do recursive call on appropriate part of array
            if (middleValue > searchValue)
            {
                return BinarySearch(searchValue, searchArray, lowerBound, middleLocation - 1);
            }
            else
            {
                return BinarySearch(searchValue, searchArray, middleLocation + 1, upperBound);
            }

        }
    }
}
