using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphs
{
    /// <summary>
    /// Tests the Graph class
    /// </summary>
    static class TestGraph
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Graph Test Cases");
            Console.WriteLine("----------------");
            Console.WriteLine();

            // Property test case
            TestPropertiesNewGraph();
            Console.WriteLine();

            // Clear test case
            TestClear();
            Console.WriteLine();

            // AddNode test cases
            TestAddNodeEmptyGraph();
            TestAddNodeMultipleNodes();
            TestAddNodeDuplicateNode();
            Console.WriteLine();

            // AddEdge test cases
            TestAddEdgeValid();
            TestAddEdgeDuplicate();
            TestAddEdgeNodeNotFound();
            Console.WriteLine();

            // RemoveNode test cases
            TestRemoveNodeNoNeighbors();
            TestRemoveNodeMultipleNeighbors();
            TestRemoveNodeNotInGraph();
            Console.WriteLine();

            // RemoveEdge test cases
            TestRemoveEdgeValid();
            TestRemoveEdgeNodeNotFound();
            TestRemoveEdgeEdgeNotFound();
            Console.WriteLine();

            // Find test cases
            TestFindNodeInGraph();
            TestFindNodeNotInGraph();
        }

        #region Property test cases

        /// <summary>
        /// Test properties for a new graph
        /// </summary>
        static void TestPropertiesNewGraph()
        {
            Graph<int> graph = new Graph<int>();
            Console.Write("TestPropertiesNewGraph: ");
            if (graph.Count == 0 &&
                graph.Nodes.Count == 0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 0 and 0 Actual: " +
                    graph.Count + " and " + graph.Nodes.Count);
            }
        }

        #endregion

        #region Clear test cases

        /// <summary>
        /// Test clearing a graph
        /// </summary>
        static void TestClear()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddEdge(4, 5);
            graph.Clear();
            Console.Write("TestClear: ");
            string graphString = graph.ToString();
            if (graphString.Equals("") &&
                graph.Count == 0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: empty string" +
                    " and 0 Actual: " +
                    graphString + " and " + graph.Count);
            }
        }

        #endregion

        #region AddNode test cases

        /// <summary>
        /// Test adding a node to an empty graph
        /// </summary>
        static void TestAddNodeEmptyGraph()
        {
            Graph<int> graph = new Graph<int>();
            bool success = graph.AddNode(4);
            Console.Write("TestAddNodeEmptyGraph: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]") &&
                graph.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Neighbors: ], 1, and true Actual: " + graphString +
                    ", " + graph.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a graph with multiple nodes
        /// </summary>
        static void TestAddNodeMultipleNodes()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.AddNode(6);
            Console.Write("TestAddNodeMultipleNodes: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]," +
                    "[Node Value: 6 Neighbors: ]") &&
                graph.Count == 3 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]," +
                    "[Node Value: 6 Neighbors: ], 3, and true Actual: " +
                    graphString +
                    ", " + graph.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a duplicate node to a node in the graph
        /// </summary>
        static void TestAddNodeDuplicateNode()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.AddNode(5);
            Console.Write("TestAddNodeDuplicateNode: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]") &&
                graph.Count == 2 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ], 1, and false Actual: " + graphString +
                    ", " + graph.Count + " and " +
                    success);
            }
        }

        #endregion

        #region AddEdge test cases

        /// <summary>
        /// Test adding a valid edge between two nodes
        /// </summary>
        static void TestAddEdgeValid()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.AddEdge(4, 5);
            Console.Write("TestAddEdgeValid: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ]") &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ] and true Actual: " +
                    graphString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding a duplicate edge between two nodes
        /// </summary>
        static void TestAddEdgeDuplicate()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddEdge(4, 5);
            bool success = graph.AddEdge(4, 5);
            Console.Write("TestAddEdgeDuplicate: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ] and false Actual: " +
                    graphString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding an edge to a non-existent node
        /// </summary>
        static void TestAddEdgeNodeNotFound()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.AddEdge(4, 6);
            Console.Write("TestAddEdgeNodeNotFound: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ] and false Actual: " +
                    graphString + " and " + success);
            }
        }

        #endregion

        #region RemoveNode test cases

        /// <summary>
        /// Test removing a node with no neighbors from the graph
        /// </summary>
        static void TestRemoveNodeNoNeighbors()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.RemoveNode(4);
            Console.Write("TestRemoveNodeNoNeighbors: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 5 Neighbors: ]") &&
                graph.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 5 Neighbors: ], 1, and true Actual: " +
                    graphString +
                    ", " + graph.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test removing a node with multiple neighbors from the graph
        /// </summary>
        static void TestRemoveNodeMultipleNeighbors()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(6);
            graph.AddEdge(4, 5);
            graph.AddEdge(4, 6);
            graph.AddEdge(5, 6);
            bool success = graph.RemoveNode(4);
            Console.Write("TestRemoveNodeMultipleNeighbors: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 5 Neighbors: 6 ]," +
                    "[Node Value: 6 Neighbors: 5 ]") &&
                graph.Count == 2 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 5 Neighbors: 6 ]," +
                    "[Node Value: 6 Neighbors: 5 ], 2 and true Actual: " +
                    graphString + " and " + graph.Count + " and " + success);
            }
        }

        /// <summary>
        /// Test removing a node that's not in the graph
        /// </summary>
        static void TestRemoveNodeNotInGraph()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            bool success = graph.RemoveNode(6);
            Console.Write("TestRemoveNodeNotInGraph: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]") &&
                graph.Count == 2 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ], 2, and false Actual: " +
                    graphString +
                    ", " + graph.Count + " and " +
                    success);
            }
        }

        #endregion

        #region RemoveEdge test cases

        /// <summary>
        /// Test removing a valid edge between two nodes
        /// </summary>
        static void TestRemoveEdgeValid()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddEdge(4, 5);
            bool success = graph.RemoveEdge(4, 5);
            Console.Write("TestRemoveEdgeValid: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ]") &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: ]," +
                    "[Node Value: 5 Neighbors: ] and true Actual: " +
                    graphString + " and " + success);
            }
        }

        /// <summary>
        /// Test removing an edge to a node not in the graph
        /// </summary>
        static void TestRemoveEdgeNodeNotFound()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddEdge(4, 5);
            bool success = graph.RemoveEdge(4, 6);
            Console.Write("TestRemoveEdgeNodeNotFound: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ] and false Actual: " +
                    graphString + " and " + success);
            }
        }

        /// <summary>
        /// Test removing a non-existent edge from the graph
        /// </summary>
        static void TestRemoveEdgeEdgeNotFound()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            graph.AddNode(6);
            graph.AddEdge(4, 5);
            bool success = graph.RemoveEdge(4, 6);
            Console.Write("TestRemoveEdgeEdgeNotFound: ");
            string graphString = graph.ToString();
            if (graphString.Equals("[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ]," +
                    "[Node Value: 6 Neighbors: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "[Node Value: 4 Neighbors: 5 ]," +
                    "[Node Value: 5 Neighbors: 4 ]," +
                    "[Node Value: 6 Neighbors: ] and false Actual: " +
                    graphString + " and " + success);
            }
        }

        #endregion

        #region Find test cases

        /// <summary>
        /// Test finding a node that's in the graph
        /// </summary>
        static void TestFindNodeInGraph()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            GraphNode<int> node = graph.Find(4);
            Console.Write("TestFindNodeInGraph: ");
            if (node != null &&
                node.Value == 4)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected to find node 4");
            }
        }

        /// <summary>
        /// Test finding a node that's not in the graph
        /// </summary>
        static void TestFindNodeNotInGraph()
        {
            Graph<int> graph = new Graph<int>();
            graph.AddNode(4);
            graph.AddNode(5);
            GraphNode<int> node = graph.Find(6);
            Console.Write("TestFindNodeInGraph: ");
            if (node == null)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Didn't expect to find node 6");
            }
        }

        #endregion
    }
}
