using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// Tests the TreeNode class
    /// </summary>
    class TestTreeNode
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("TreeNode Test Cases");
            Console.WriteLine("--------------------");
            Console.WriteLine();

            // Property test cases
            TestPropertiesNewTreeNode();
            Console.WriteLine();

            // AddChild test cases
            TestAddChildEmptyChildren();
            TestAddChildMultipleChildren();
            TestAddChildDuplicateChild();
            TestAddChildSelf();
            Console.WriteLine();

            // RemoveChild test cases
            TestRemoveChildMultipleChildren();
            TestRemoveChildChildNotFound();
            Console.WriteLine();

            // RemoveAllChildren test cases
            TestRemoveAllChildrenMultipleChildren();
            Console.WriteLine();
        }

        #region Property test cases

        /// <summary>
        /// Test properties for a new tree node
        /// </summary>
        static void TestPropertiesNewTreeNode()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            Console.Write("TestPropertiesNewTreeNode: ");
            if (node.Value == 4 &&
                node.Parent == null &&
                node.Children.Count == 0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 4, null, and 0 Actual: " +
                    node.Value + ", " + node.Parent + ", and " + node.Children.Count);
            }
        }

        #endregion

        #region AddChild test cases

        /// <summary>
        /// Test adding a Child to an empty list of Children
        /// </summary>
        static void TestAddChildEmptyChildren()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            bool success = node.AddChild(new TreeNode<int>(5, node));
            Console.Write("TestAddChildEmptyChildren: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: 5 ]") &&
                node.Children.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: 5 ], 1, and true Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a Child to a list of multiple Children
        /// </summary>
        static void TestAddChildMultipleChildren()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            node.AddChild(new TreeNode<int>(5, node));
            bool success = node.AddChild(new TreeNode<int>(6, node));
            Console.Write("TestAddChildMultipleChildren: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: 5 6 ]") &&
                node.Children.Count == 2 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: 5 6 ], 2, and true Actual: " + nodeString +
                    ", " + node.Children.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test adding a duplicate Child to a list of Children
        /// </summary>
        static void TestAddChildDuplicateChild()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            TreeNode<int> duplicateNode = new TreeNode<int>(5, node);
            node.AddChild(duplicateNode);
            bool success = node.AddChild(duplicateNode);
            Console.Write("TestAddChildDuplicateChild: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: 5 ]") &&
                node.Children.Count == 1 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: 5 ], 1, and false Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Tests adding self as a child
        /// </summary>
        static void TestAddChildSelf()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            bool success = node.AddChild(node);
            Console.Write("TestAddChildSelf: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: ]") &&
                node.Children.Count == 0 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: ], 0, and false Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        #endregion

        #region RemoveChild test cases

        /// <summary>
        /// Test removing a Child from a list of multiple Children
        /// </summary>
        static void TestRemoveChildMultipleChildren()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            TreeNode<int> removeNode = new TreeNode<int>(5, node);
            node.AddChild(removeNode);
            node.AddChild(new TreeNode<int>(6, node));
            bool success = node.RemoveChild(removeNode);
            Console.Write("TestRemoveChildMultipleChildren: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: 6 ]") &&
                node.Children.Count == 1 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: 6 ], 1, and true Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        /// <summary>
        /// Test removing a Child not in the list of Children
        /// </summary>
        static void TestRemoveChildChildNotFound()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            node.AddChild(new TreeNode<int>(5, node));
            bool success = node.RemoveChild(new TreeNode<int>(6, node));
            Console.Write("TestRemoveChildChildNotFound: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: 5 ]") &&
                node.Children.Count == 1 &&
                !success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: 5 ], 1, and false Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        #endregion

        #region RemoveAllChildren test cases

        /// <summary>
        /// Test removing all Child from a list of multiple Children
        /// </summary>
        static void TestRemoveAllChildrenMultipleChildren()
        {
            TreeNode<int> node = new TreeNode<int>(4, null);
            node.AddChild(new TreeNode<int>(5, node));
            node.AddChild(new TreeNode<int>(6, node));
            bool success = node.RemoveAllChildren();
            Console.Write("TestRemoveAllChildrenMultipleChildren: ");
            string nodeString = node.ToString();
            if (nodeString.Equals("[Node Value: 4 Parent: null Children: ]") &&
                node.Children.Count == 0 &&
                success)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: [Node Value: 4  " +
                    "Parent: null Children: ], 0, and true Actual: " + 
                    nodeString + ", " + node.Children.Count + " and " +
                    success);
            }
        }

        #endregion
    }
}
