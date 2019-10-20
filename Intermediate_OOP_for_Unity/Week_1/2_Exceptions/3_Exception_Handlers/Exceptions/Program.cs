using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions {
    /// <summary>
    /// Exceptions lectures code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates exceptions and exception handling
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // prompt for and get a short
            Console.Write("Enter a whole number (-32,768 to 32,767): ");
            try {
                short input = short.Parse(Console.ReadLine());
            } catch (FormatException fe) {
                Console.WriteLine("Not a whole number");
            } catch (OverflowException oe) {
                Console.WriteLine("Number out of range");
            } finally {
                Console.WriteLine("All done");
            }
            

            Console.WriteLine();
        }
    }
}
