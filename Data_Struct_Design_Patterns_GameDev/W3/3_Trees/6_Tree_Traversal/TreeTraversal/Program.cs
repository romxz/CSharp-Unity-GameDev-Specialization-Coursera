using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeTraversal
{
    /// <summary>
    /// Tree Traversal lecture code
    /// </summary>
    class Program
    {
        /// <summary>
        /// Demonstrates traversing a tree
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            BinaryTree<char> tree = BuildTree();

            // depth-first traversals
            Console.WriteLine("Pre-order Traversal");
            Console.WriteLine("-------------------");
            PreOrderTraversal(tree.Root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("In-order Traversal");
            Console.WriteLine("------------------");
            InOrderTraversal(tree.Root);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Post-order Traversal");
            Console.WriteLine("-------------------");
            PostOrderTraversal(tree.Root);
            Console.WriteLine();
            Console.WriteLine();

            // breadth-first traversal
            Console.WriteLine("Breadth-First Traversal");
            Console.WriteLine("-----------------------");
            BreadthFirstTraversal(tree.Root);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine();
        }

        /// <summary>
        /// Builds a tree
        /// 
        /// Reference: https://en.wikipedia.org/wiki/Tree_traversal
        /// </summary>
        /// <returns>tree</returns>
        static BinaryTree<char> BuildTree()
        {
            BinaryTree<char> tree = new BinaryTree<char>('F');
            BinaryTreeNode<char> nodeB = new BinaryTreeNode<char>('B', tree.Root);
            tree.AddNode(nodeB, ChildSide.Left);
            BinaryTreeNode<char> nodeA = new BinaryTreeNode<char>('A', nodeB);
            tree.AddNode(nodeA, ChildSide.Left);
            BinaryTreeNode<char> nodeD = new BinaryTreeNode<char>('D', nodeB);
            tree.AddNode(nodeD, ChildSide.Right);
            BinaryTreeNode<char> nodeC = new BinaryTreeNode<char>('C', nodeD);
            tree.AddNode(nodeC, ChildSide.Left);
            BinaryTreeNode<char> nodeE = new BinaryTreeNode<char>('E', nodeD);
            tree.AddNode(nodeE, ChildSide.Right);
            BinaryTreeNode<char> nodeG = new BinaryTreeNode<char>('G', tree.Root);
            tree.AddNode(nodeG, ChildSide.Right);
            BinaryTreeNode<char> nodeI = new BinaryTreeNode<char>('I', nodeG);
            tree.AddNode(nodeI, ChildSide.Right);
            BinaryTreeNode<char> nodeH = new BinaryTreeNode<char>('H', nodeI);
            tree.AddNode(nodeH, ChildSide.Left);
            return tree;
        }

        /// <summary>
        /// Completes a pre-order traversal of the tree
        /// rooted at the given node
        /// </summary>
        /// <param name="tree">tree to traverse</param>
        static void PreOrderTraversal(BinaryTreeNode<char> tree)
        {
            if (tree != null)
            {
                Console.Write(tree.Value + " ");
                if (tree.Left != null)
                {
                    PreOrderTraversal(tree.Left);
                }
                if (tree.Right != null)
                {
                    PreOrderTraversal(tree.Right);
                }
            }
        }

        /// <summary>
        /// Completes an in-order traversal of the tree
        /// rooted at the given node
        /// </summary>
        /// <param name="tree">tree to traverse</param>
        static void InOrderTraversal(BinaryTreeNode<char> tree)
        {
            if (tree != null)
            {
                if (tree.Left != null)
                {
                    InOrderTraversal(tree.Left);
                }
                Console.Write(tree.Value + " ");
                if (tree.Right != null)
                {
                    InOrderTraversal(tree.Right);
                }
            }
        }

        /// <summary>
        /// Completes a post-order traversal of the tree
        /// rooted at the given node
        /// </summary>
        /// <param name="tree">tree to traverse</param>
        static void PostOrderTraversal(BinaryTreeNode<char> tree)
        {
            if (tree != null)
            {
                if (tree.Left != null)
                {
                    PostOrderTraversal(tree.Left);
                }
                if (tree.Right != null)
                {
                    PostOrderTraversal(tree.Right);
                }
                Console.Write(tree.Value + " ");
            }
        }

        /// <summary>
        /// Completes a breadth-first traversal of the tree
        /// rooted at the given node
        /// </summary>
        /// <param name="tree">tree to traverse</param>
        static void BreadthFirstTraversal(BinaryTreeNode<char> tree)
        {
            if (tree != null)
            {
                LinkedList<BinaryTreeNode<char>> searchList =
                    new LinkedList<BinaryTreeNode<char>>();
                searchList.AddLast(tree);
                while (searchList.Count > 0)
                {
                    BinaryTreeNode<char> node = searchList.First.Value;
                    searchList.RemoveFirst();
                    Console.Write(node.Value + " ");
                    if (node.Left != null)
                    {
                        searchList.AddLast(node.Left);
                    }
                    if (node.Right != null)
                    {
                        searchList.AddLast(node.Right);
                    }
                }
            }
        }
    }
}

