using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinimaxImplementation
{
    /// <summary>
    /// Minimax Implementation lecture code
    /// </summary>
    class Program
    {
        // saved for efficiency
        static List<int> binContents = new List<int>();
        static List<Configuration> newConfigurations =
            new List<Configuration>();

        /// <summary>
        /// Executes minimax search
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args)
        {
            // build and mark the tree with minimax scores
            MinimaxTree<Configuration> tree = BuildTree();
            Minimax(tree.Root, true);

            // find child node with maximum score
            IList<MinimaxTreeNode<Configuration>> children = 
                tree.Root.Children;
            MinimaxTreeNode<Configuration> maxChildNode = children[0];
            for (int i = 1; i < children.Count; i++)
            {
                if (children[i].MinimaxScore > maxChildNode.MinimaxScore)
                {
                    maxChildNode = children[i];
                }
            }

            Console.WriteLine("Best move is to configuration " + 
                maxChildNode.Value);
            Console.WriteLine();
        }

        /// <summary>
        /// Builds the tree
        /// </summary>
        /// <returns>tree</returns>
        static MinimaxTree<Configuration> BuildTree()
        {
            // build root node
            binContents.Clear();
            binContents.Add(2);
            binContents.Add(1);
            Configuration rootConfiguration =
                new Configuration(binContents);

            // build complete tree
            MinimaxTree<Configuration> tree =
                new MinimaxTree<Configuration>(rootConfiguration);
            LinkedList<MinimaxTreeNode<Configuration>> nodeList =
                new LinkedList<MinimaxTreeNode<Configuration>>();
            nodeList.AddLast(tree.Root);
            while (nodeList.Count > 0)
            {
                MinimaxTreeNode<Configuration> currentNode =
                    nodeList.First.Value;
                nodeList.RemoveFirst();
                List<Configuration> children =
                    GetNextConfigurations(currentNode.Value);
                foreach (Configuration child in children)
                {
                    MinimaxTreeNode<Configuration> childNode =
                        new MinimaxTreeNode<Configuration>(
                            child, currentNode);
                    tree.AddNode(childNode);
                    nodeList.AddLast(childNode);
                }
            }
            return tree;
        }

        /// <summary>
        /// Gets a list of the possible next configurations
        /// given the current configuration
        /// </summary>
        /// <param name="currentConfiguration">current configuration</param>
        /// <returns>list of next configurations</returns>
        static List<Configuration> GetNextConfigurations(
            Configuration currentConfiguration)
        {
            newConfigurations.Clear();
            IList<int> currentBins = currentConfiguration.Bins;
            for (int i = 0; i < currentBins.Count; i++)
            {
                int currentBinCount = currentBins[i];
                while (currentBinCount > 0)
                {
                    // take one teddy from current bin
                    currentBinCount--;

                    // add new next configuration to list
                    binContents.Clear();
                    binContents.AddRange(currentBins);
                    binContents[i] = currentBinCount;
                    newConfigurations.Add(
                        new Configuration(binContents));
                }
            }
            return newConfigurations;
        }

        /// <summary>
        /// Assigns minimax scores to the tree nodes
        /// </summary>
        /// <param name="tree">tree to mark with scores</param>
        /// <param name="maximizing">whether or not we're maximizing</param>
        static void Minimax(MinimaxTreeNode<Configuration> tree,
            bool maximizing)
        {
            // recurse on children
            IList<MinimaxTreeNode<Configuration>> children = tree.Children;
            if (children.Count > 0)
            {
                foreach (MinimaxTreeNode<Configuration> child in children)
                {
                    // toggle maximizing as we move down
                    Minimax(child, !maximizing);
                }

                // set default node minimax score
                if (maximizing)
                {
                    tree.MinimaxScore = int.MinValue;
                }
                else
                {
                    tree.MinimaxScore = int.MaxValue;
                }

                // find maximum or minimum value in children
                foreach (MinimaxTreeNode<Configuration> child in children)
                {
                    if (maximizing)
                    {
                        // check for higher minimax score
                        if (child.MinimaxScore > tree.MinimaxScore)
                        {
                            tree.MinimaxScore = child.MinimaxScore;
                        }
                    }
                    else
                    {
                        // minimizing, check for lower minimax score
                        if (child.MinimaxScore < tree.MinimaxScore)
                        {
                            tree.MinimaxScore = child.MinimaxScore;
                        }
                    }
                }
            }
            else
            {
                // leaf nodes are the base case
                AssignMinimaxScore(tree, maximizing);
            }
        }

        /// <summary>
        /// Assigns a minimax score to the given node
        /// </summary>
        /// <param name="node">node to mark with score</param>
        static void AssignMinimaxScore(
            MinimaxTreeNode<Configuration> node, 
            bool maximizing)
        {
            // for the lecture, only score end-of-game configurations
            if (node.Value.Empty)
            {
                if (maximizing)
                {
                    // player 2 took the last teddy
                    node.MinimaxScore = 1;
                }
                else
                {
                    // player 1 took the last teddy
                    node.MinimaxScore = 0;
                }
            }
        }
    }
}
