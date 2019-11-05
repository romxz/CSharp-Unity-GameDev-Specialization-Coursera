using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionFactorial
{
    /// <remarks>
    /// Demonstrates factorial calculation using both recursion and a loop
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Calculates factorials until user enters a negative number
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            int n = 0;
            while (n >= 0)
            {
                // prompt for and get input
                Console.Write("Enter n for factorial calculation (negative number to quit): ");
                n = Int32.Parse(Console.ReadLine());

                if (n >= 0)
                {
                    Console.WriteLine("Factorial calculated recursively: " + factorial(n));
                    Console.WriteLine("Factorial calculated with a loop: " + loopFactorial(n));
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Calculates factorial recursively
        /// </summary>
        /// <param name="n">the number for which to calculate the factorial</param>
        /// <returns>n!</returns>
        static int factorial(int n)
        {
            // check for termination condition
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * factorial(n - 1);
            }
        }

        /// <summary>
        /// Calculates factorial using a loop
        /// </summary>
        /// <param name="n">the number for which to calculate the factorial</param>
        /// <returns>n!</returns>
        static int loopFactorial(int n)
        {
            int factorial = 1;
            for (int i = 1; i <= n; i++)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
