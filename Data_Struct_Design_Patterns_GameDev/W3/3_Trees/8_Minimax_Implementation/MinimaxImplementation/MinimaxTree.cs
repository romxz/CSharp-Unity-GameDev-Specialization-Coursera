using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimaxImplementation
{
    /// <summary>
    /// A minimax tree
    /// </summary>
    /// <typeparam name="T">type of values stored in tree</typeparam>
    class MinimaxTree<T>
    {
        #region Fields

        MinimaxTreeNode<T> root = null;
        List<MinimaxTreeNode<T>> nodes = new List<MinimaxTreeNode<T>>();

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">value of the root node</param>
        public MinimaxTree(T value)
        {
            root = new MinimaxTreeNode<T>(value, null);
            nodes.Add(root);
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of nodes in the tree
        /// </summary>
        public int Count
        {
            get { return nodes.Count; }
        }

        /// <summary>
        /// Gets the root of the tree
        /// </summary>
        public MinimaxTreeNode<T> Root
        {
            get { return root; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Clears all the nodes from the tree
        /// </summary>
        void Clear()
        {
            // remove all the children from each node
            // so nodes can be garbage collected
            foreach (MinimaxTreeNode<T> node in nodes)
            {
                node.Parent = null;
                node.RemoveAllChildren();
            }

            // now remove all the nodes from the tree and set root to null
            for (int i = nodes.Count - 1; i >= 0; i--)
            {
                nodes.RemoveAt(i);
            }
            root = null;
        }

        /// <summary>
        /// Adds the given node to the tree. If the given node is
        /// null the method returns false. If the parent node is null
        /// or isn't in the tree the method returns false. If the given
        /// node is already a child of the parent node the method returns
        /// false
        /// </summary>
        /// <param name="node">node to add</param>
        /// <returns>true if the node is added, false otherwise</returns>
        public bool AddNode(MinimaxTreeNode<T> node)
        {
            if (node == null ||
                node.Parent == null ||
                !nodes.Contains(node.Parent))
            {
                return false;
            }
            else if (node.Parent.Children.Contains(node))
            {
                // node already a child of parent
                return false;
            }
            else
            {
                // add child as tree node and as a child to parent
                nodes.Add(node);
                return node.Parent.AddChild(node);
            }
        }

        /// <summary>
        /// Removes the given node from the tree. If the node isn't 
        /// found in the tree, the method returns false.
        /// 
        /// Note that the subtree with the node to remove as its
        /// root is pruned from the tree
        /// </summary>
        /// <param name="removeNode">node to remove</param>
        /// <returns>true if the node is removed, false otherwise</returns>
        public bool RemoveNode(MinimaxTreeNode<T> removeNode)
        {
            if (removeNode == null)
            {
                return false;
            }
            else if (removeNode == root)
            {
                // removing the root clears the tree
                Clear();
                return true;
            }
            else
            {
                // remove as child of parent
                bool success = removeNode.Parent.RemoveChild(removeNode);
                if (!success)
                {
                    return false;
                }

                // remove node from tree
                success = nodes.Remove(removeNode);
                if (!success)
                {
                    return false;
                }

                // check for branch node
                if (removeNode.Children.Count > 0)
                {
                    // recursively prune subtree
                    IList<MinimaxTreeNode<T>> children = removeNode.Children;
                    for (int i = children.Count - 1; i >= 0; i--)
                    {
                        RemoveNode(children[i]);
                    }
                }

                return true;
            }
        }

        /// <summary>
        /// Finds a tree node with the given value. If there
        /// are multiple tree nodes with the given value the
        /// method returns the first one it finds
        /// </summary>
        /// <param name="value">value to find</param>
        /// <returns>tree node or null if not found</returns>
        public MinimaxTreeNode<T> Find(T value)
        {
            foreach (MinimaxTreeNode<T> node in nodes)
            {
                if (node.Value.Equals(value))
                {
                    return node;
                }
            }
            return null;
        }

        /// <summary>
        /// Converts the tree to a comma-separated string of nodes
        /// </summary>
        /// <returns>comma-separated string of nodes</returns>
        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Root: ");
            if (root != null)
            {
                builder.Append(root.Value + " ");
            }
            else
            {
                builder.Append("null");
            }
            for (int i = 0; i < Count; i++)
            {
                builder.Append(nodes[i].ToString());
                if (i < Count - 1)
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }

        #endregion
    }
}
