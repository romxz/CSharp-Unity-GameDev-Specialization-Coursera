using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleExercise {
    /// <summary>
    /// Exercise 9, 10, and 11 solution
    /// </summary>
    class Program {
        /// <summary>
        /// Tests the apple class
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // test constructor and properties
            Apple apple = new Apple(true, 1.5f);
            Console.WriteLine("Organic? " + apple.Organic);
            Console.WriteLine("Amount Left: " + apple.AmountLeft);

            Console.WriteLine();
        }
    }
}
