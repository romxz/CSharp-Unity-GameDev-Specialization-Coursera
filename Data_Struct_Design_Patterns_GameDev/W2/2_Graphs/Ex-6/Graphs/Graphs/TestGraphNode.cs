using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    /// <summary>
    /// Tests the GraphNode class
    /// </summary>
    static class TestGraphNode
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("GraphNode Test Cases");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            // Property test cases
            TestPropertiesNewGraphNode();
            Console.WriteLine();

            // AddNeighbor test cases
            TestAddNeighborEmptyNeighbors();
            TestAddNeighborMultipleNeighbors();
            TestAddNeighborDuplicateNeighbor();
            Console.WriteLine();

            // RemoveNeighbor test cases
            TestRemoveNeighborMultipleNeighbors();
            TestRemoveNeighborNeighborNotFound();
            Console.WriteLine();

            // RemoveAllNeighbors test cases
            TestRemoveAllNeighborsMultipleNeighbors();
            Console.WriteLine();
        }

        #region Property test cases

        /// <summary>
        /// Test properties for a new graph node
        /// </summary>
        static void TestPropertiesNewGraphNode()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            Console.Write("TestPropertiesNewGraphNode: ");
            if (node.Value == 4 &&
                node.Neighbors.Count == 0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 4 and 0 Actual: " + 
                    node.Value + " and " + node.Neighbors.Count);
            }
        }

        #endregion

        #region AddNeighbor test cases

        /// <summary>
        /// Test adding a neighbor to an empty list of neighbors
        /// </summary>
        static void TestAddNeighborEmptyNeighbors()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            bool success = node.AddNeighbor(new GraphNode<int>(5));
            Console.Write("TestAddNeighborEmptyNeighbors: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: 5 ]") &&
                node.Neighbors.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: 5 ], 1, and true Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a neighbor to a list of multiple neighbors
        /// </summary>
        static void TestAddNeighborMultipleNeighbors()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            node.AddNeighbor(new GraphNode<int>(5));
            bool success = node.AddNeighbor(new GraphNode<int>(6));
            Console.Write("TestAddNeighborMultipleNeighbors: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: 5 6 ]") &&
                node.Neighbors.Count == 2 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: 5 6 ], 2, and true Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a duplicate neighbor to a list of neighbors
        /// </summary>
        static void TestAddNeighborDuplicateNeighbor()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            GraphNode<int> duplicateNode = new GraphNode<int>(5);
            node.AddNeighbor(duplicateNode);
            bool success = node.AddNeighbor(duplicateNode);
            Console.Write("TestAddNeighborDuplicateNeighbor: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: 5 ]") &&
                node.Neighbors.Count == 1 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: 5 ], 1, and false Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        #endregion

        #region RemoveNeighbor test cases

        /// <summary>
        /// Test removing a neighbor from a list of multiple neighbors
        /// </summary>
        static void TestRemoveNeighborMultipleNeighbors()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            GraphNode<int> removeNode = new GraphNode<int>(5);
            node.AddNeighbor(removeNode);
            node.AddNeighbor(new GraphNode<int>(6));
            bool success = node.RemoveNeighbor(removeNode);
            Console.Write("TestRemoveNeighborMultipleNeighbors: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: 6 ]") &&
                node.Neighbors.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: 6 ], 1, and true Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test removing a neighbor not in the list of neighbors
        /// </summary>
        static void TestRemoveNeighborNeighborNotFound()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            node.AddNeighbor(new GraphNode<int>(5));
            bool success = node.RemoveNeighbor(new GraphNode<int>(6));
            Console.Write("TestRemoveNeighborNeighborNotFound: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: 5 ]") &&
                node.Neighbors.Count == 1 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: 5 ], 1, and false Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        #endregion

        #region RemoveAllNeighbors test cases

        /// <summary>
        /// Test removing all neighbor from a list of multiple neighbors
        /// </summary>
        static void TestRemoveAllNeighborsMultipleNeighbors()
        {
            GraphNode<int> node = new GraphNode<int>(4);
            node.AddNeighbor(new GraphNode<int>(5));
            node.AddNeighbor(new GraphNode<int>(6));
            bool success = node.RemoveAllNeighbors();
            Console.Write("TestRemoveAllNeighborsMultipleNeighbors: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Neighbors: ]") &&
                node.Neighbors.Count == 0 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: ], 0, and true Actual: " + nodeString +
                    ", " + node.Neighbors.Count + " and " +
                    success);
            }
        }

        #endregion
    }
}
