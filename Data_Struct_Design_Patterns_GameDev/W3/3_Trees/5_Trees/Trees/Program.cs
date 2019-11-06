using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees {
    /// <summary>
    /// Tests the Tree and TreeNode classes
    /// </summary>
    class Program {
        /// <summary>
        /// Tests classes
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            TestTreeNode.RunTestCases();
            TestTree.RunTestCases();
            Console.WriteLine();
        }
    }
}
