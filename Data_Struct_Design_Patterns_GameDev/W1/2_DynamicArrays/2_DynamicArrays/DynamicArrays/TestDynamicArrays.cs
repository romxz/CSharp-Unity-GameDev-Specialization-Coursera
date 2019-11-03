using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays {
    /// <remarks>
    /// Runs the test cases for all the dynamic array classes
    /// </remarks>
    class TestDynamicArrays {
        /// <summary>
        /// Tests the classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // test cases for integer dynamic arrays
            TestUnorderedIntDynamicArray.RunTestCases();
            TestOrderedIntDynamicArray.RunTestCases();

            // test cases for generic dynamic arrays
            TestUnorderedDynamicArray.RunTestCases();
            TestOrderedDynamicArray.RunTestCases();
        }
    }
}
