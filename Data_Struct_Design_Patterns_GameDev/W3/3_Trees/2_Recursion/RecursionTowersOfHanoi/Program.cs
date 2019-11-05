using System;
using System.Collections.Generic;
using System.Text;

namespace RecursionTowersOfHanoi
{
    /// <remarks>
    /// Demonstrates a recursive solution to Towers of Hanoi
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Loops through Towers of Hanoi solutions until user quits
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            int n = 0;
            while (n >= 0)
            {
                // prompt for and get input
                Console.Write("Enter n for number of Towers of Hanoi disks (negative number to quit): ");
                n = Int32.Parse(Console.ReadLine());

                if (n >= 0)
                {
                    Hanoi(n, 0, 2, 1);
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Recursively solves the Towers of Hanoi problem
        /// </summary>
        /// <param name="n">the number of disks to move</param>
        /// <param name="start">the start peg</param>
        /// <param name="destination">the destination peg</param>
        /// <param name="open">the open peg</param>
        static void Hanoi(int n, int start, int destination, int open)
        {
            // only solve if not termination condition
            if (n != 0)
            {
                // move n - 1 disks to open peg
                Hanoi(n - 1, start, open, destination);

                // move n disk to destination peg (note it just prints a message)
                Console.WriteLine("Moving disk " + n + " from peg " + start + " to peg " + destination);

                // move n - 1 disks to destination peg
                Hanoi(n - 1, open, destination, start);
            }
        }
    }
}
