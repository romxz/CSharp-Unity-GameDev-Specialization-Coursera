using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingAnInterface {
    /// <summary>
    /// Implementing an Interface lecture code
    /// </summary>
    class Program {
        /// <summary>
        /// Demonstrates implementing an interface
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // create array of rectangles
            OrderedDynamicArray<Rectangle> rectangles =
                new OrderedDynamicArray<Rectangle>();
            // add rectangles to array
            rectangles.Add(new Rectangle(3, 4));
            rectangles.Add(new Rectangle(2, 2));
            rectangles.Add(new Rectangle(1, 2));

            // print rectangles in array
            Console.WriteLine(rectangles.ToString());

            Console.WriteLine();
        }
    }
}
