using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    /// <summary>
    /// Exercise 15 solution
    /// </summary>
    class Program
    {
        /// <summary>
        /// Extracts and prints block information
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // prompt for and read in string
            Console.Write("Enter <pyramid slot>,<block letter>,<true or false for block lit>: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            // extract and print pyramid slot number
            int commaLocation = input.IndexOf(',');
            int slotNumber = int.Parse(input.Substring(0, commaLocation));
            Console.WriteLine("Slot Number: " + slotNumber);

            // extract and print block letter
            char blockLetter = input[commaLocation + 1];
            Console.WriteLine("Block Letter: " + blockLetter);

            // extract and print whether or not the block should be lit
            string temp = input.Substring(commaLocation + 1);
            commaLocation = temp.IndexOf(',');
            bool lit = bool.Parse(temp.Substring(commaLocation + 1));
            Console.WriteLine("Block should be lit: " + lit);

            Console.WriteLine();
        }
    }
}