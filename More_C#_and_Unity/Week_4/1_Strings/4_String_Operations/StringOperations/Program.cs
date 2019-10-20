using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringOperations {
    /// <summary>
    /// String Operations lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates IndexOf and Substring methods
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // read in csv string
            Console.Write("Enter name and percent (name, percent): ");
            string csvString = Console.ReadLine();

            // find comma location
            int commaLocation = csvString.IndexOf(",");
            Console.WriteLine("Comma location: " + commaLocation);

            // extract name and percent
            string name = csvString.Substring(0, commaLocation);
            float percent = float.Parse(csvString.Substring(commaLocation + 1));

            // print name and percent
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Percent: " + percent);

            Console.WriteLine();
        }
    }
}
