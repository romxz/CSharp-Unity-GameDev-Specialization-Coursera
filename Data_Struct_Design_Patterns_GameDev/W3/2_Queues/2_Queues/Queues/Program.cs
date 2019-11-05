using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    /// <remarks>
    /// Runs the test cases for the Queue and PriorityQueue classes
    /// </remarks>
    class Program
    {
        /// <summary>
        /// Run test cases
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            TestQueue.RunTestCases();
            TestPriorityQueue.RunTestCases();
        }
    }
}
