using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// Tests the Tree class
    /// </summary>
    static class TestTree
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Tree Test Cases");
            Console.WriteLine("----------------");
            Console.WriteLine();

            // Property test case
            TestPropertiesNewTree();
            Console.WriteLine();

            // AddNode test cases
            TestAddNodeValid();
            TestAddNodeNullNode();
            TestAddNodeNullParent();
            TestAddNodeParentNotInTree();
            TestAddNodeDuplicateChild();
            Console.WriteLine();

            // RemoveNode test cases
            TestRemoveLeafNode();
            TestRemoveBranchNode();
            TestRemoveRoot();
            TestRemoveNodeNotInTree();
            Console.WriteLine();

            // Find test cases
            TestFindNodeInTree();
            TestFindNodeNotInTree();
        }

        #region Property test cases

        /// <summary>
        /// Test properties for a new tree
        /// </summary>
        static void TestPropertiesNewTree()
        {
            Tree<int> tree = new Tree<int>(42);
            Console.Write("TestPropertiesNewTree: ");
            if (tree.Count == 1 &&
                tree.Root.Value == 42)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 1 and 42 Actual: " +
                    tree.Count + " and " + tree.Root.Value);
            }
        }

        #endregion

        #region AddChild test cases

        /// <summary>
        /// Test adding a valid child between two nodes
        /// </summary>
        static void TestAddNodeValid()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            bool success = tree.AddNode(node5);
            Console.Write("TestAddNodeValid: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ]") &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ] and true Actual: " +
                    treeString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding a null node to the tree
        /// </summary>
        static void TestAddNodeNullNode()
        {
            Tree<int> tree = new Tree<int>(4);
            bool success = tree.AddNode(null);
            Console.Write("TestAddNodeNullNode: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: ] and false Actual: " +
                    treeString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding a node with a null parent to the tree
        /// </summary>
        static void TestAddNodeNullParent()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, null);
            bool success = tree.AddNode(node5);
            Console.Write("TestAddNodeNullParent: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: ] and false Actual: " +
                    treeString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding a node with the parent not in the tree
        /// </summary>
        static void TestAddNodeParentNotInTree()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, null);
            TreeNode<int> node6 = new TreeNode<int>(6, node5);
            bool success = tree.AddNode(node6);
            Console.Write("TestAddNodeParentNotInTree: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: ] and false Actual: " +
                    treeString + " and " + success);
            }
        }

        /// <summary>
        /// Test adding a duplicate child between two nodes
        /// </summary>
        static void TestAddNodeDuplicateChild()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            tree.AddNode(node5);
            bool success = tree.AddNode(node5);
            Console.Write("TestAddNodeDuplicateChild: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ]") &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ] and false Actual: " +
                    treeString + " and " + success);
            }
        }
 
        #endregion

        #region RemoveNode test cases

        /// <summary>
        /// Test removing a leaf node from the tree
        /// </summary>
        static void TestRemoveLeafNode()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            tree.AddNode(node5);
            TreeNode<int> node6 = new TreeNode<int>(6, node5);
            tree.AddNode(node6);
            bool success = tree.RemoveNode(node6);
            Console.Write("TestRemoveLeafNode: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                "[Node Value: 5 Parent: 4 Children: ]") &&
                tree.Count == 2 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Parent: null Children: 5 ], " +
                    "[Node Value: 5 Parent: 4 Children: ], 2, and true Actual: " +
                    treeString +
                    ", " + tree.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test removing a branch node from the tree
        /// </summary>
        static void TestRemoveBranchNode()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            tree.AddNode(node5);
            TreeNode<int> node6 = new TreeNode<int>(6, node5);
            tree.AddNode(node6);
            TreeNode<int> node7 = new TreeNode<int>(7, node5);
            tree.AddNode(node7);
            TreeNode<int> node8 = new TreeNode<int>(8, node6);
            tree.AddNode(node8);
            bool success = tree.RemoveNode(node5);
            Console.Write("TestRemoveBranchNode: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: ]") &&
                tree.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: " +
                    "Root: 4 [Node Value: 4 Children: 5 ], " +
                    "2, and true Actual: " +
                    treeString +
                    ", " + tree.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test removing the root of the tree
        /// </summary>
        static void TestRemoveRoot()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            tree.AddNode(node5);
            TreeNode<int> node6 = new TreeNode<int>(6, node5);
            tree.AddNode(node6);
            TreeNode<int> node7 = new TreeNode<int>(7, node5);
            tree.AddNode(node7);
            TreeNode<int> node8 = new TreeNode<int>(8, node6);
            tree.AddNode(node8);
            bool success = tree.RemoveNode(tree.Root);
            Console.Write("TestRemoveRoot: ");
            string treeString = tree.ToString();
            if (treeString.Equals("Root: null") &&
                tree.Count == 0 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Root: null, 2," +
                    " and true Actual: " + treeString + " and " + 
                    tree.Count + " and " + success);
            }
        }

        /// <summary>
        /// Test removing a node that's not in the tree
        /// </summary>
        static void TestRemoveNodeNotInTree()
        {
            Tree<int> tree = new Tree<int>(4);
            TreeNode<int> node5 = new TreeNode<int>(5, tree.Root);
            tree.AddNode(node5);
            TreeNode<int> node6 = new TreeNode<int>(6, node5);
            bool success = tree.RemoveNode(node6);
            Console.Write("TestRemoveNodeNotInTree: ");
            string TreeString = tree.ToString();
            if (TreeString.Equals("Root: 4 [Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ]") &&
                tree.Count == 2 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Root: 4 " +
                    "[Node Value: 4 Parent: null Children: 5 ]," +
                    "[Node Value: 5 Parent: 4 Children: ], 2, and false Actual: " +
                    TreeString +
                    ", " + tree.Count + " and " +
                    success);
            }
        }

        #endregion

        #region Find test cases

        /// <summary>
        /// Test finding a node that's in the tree
        /// </summary>
        static void TestFindNodeInTree()
        {
            Tree<int> tree = new Tree<int>(5);
            tree.AddNode(new TreeNode<int>(5, tree.Root));
            TreeNode<int> node = tree.Find(5);
            Console.Write("TestFindNodeInTree: ");
            if (node != null &&
                node.Value == 5)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected to find node 5");
            }
        }

        /// <summary>
        /// Test finding a node that's not in the tree
        /// </summary>
        static void TestFindNodeNotInTree()
        {
            Tree<int> tree = new Tree<int>(4);
            tree.AddNode(new TreeNode<int>(5, tree.Root));
            TreeNode<int> node = tree.Find(6);
            Console.Write("TestFindNodeInTree: ");
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
