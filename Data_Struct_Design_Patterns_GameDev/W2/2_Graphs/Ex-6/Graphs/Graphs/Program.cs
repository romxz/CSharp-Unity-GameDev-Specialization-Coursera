using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    /// <summary>
    /// Tests Graph and GraphNode classes
    /// </summary>
    class Program
    {
        /// <summary>
        /// Tests classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            TestGraphNode.RunTestCases();
            TestGraph.RunTestCases();
            Console.WriteLine();
        }
    }
}
