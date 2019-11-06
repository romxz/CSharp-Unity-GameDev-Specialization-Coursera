using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10 {
    /// <summary>
    /// Exercise 10 solution
    /// </summary>
    class Program {
        /// <summary>
        /// Selects best first move using minimax
        /// </summary>
        /// <param name="args">command-line arguments</param>
        static void Main(string[] args) {
            // build and mark the tree with minimax scores
            MinimaxTree<char> tree = BuildTree();

            // find child node with maximum score

            // print best move

            Console.WriteLine();
        }

        /// <summary>
        /// Builds the tree
        /// </summary>
        /// <returns>tree</returns>
        static MinimaxTree<char> BuildTree() {
            MinimaxTree<char> tree = new MinimaxTree<char>('A');
            MinimaxTreeNode<char> bNode = new MinimaxTreeNode<char>('B', tree.Root);
            tree.AddNode(bNode);
            MinimaxTreeNode<char> cNode = new MinimaxTreeNode<char>('C', tree.Root);
            tree.AddNode(cNode);
            MinimaxTreeNode<char> dNode = new MinimaxTreeNode<char>('D', tree.Root);
            tree.AddNode(dNode);
            MinimaxTreeNode<char> eNode = new MinimaxTreeNode<char>('E', bNode);
            tree.AddNode(eNode);
            MinimaxTreeNode<char> fNode = new MinimaxTreeNode<char>('F', bNode);
            tree.AddNode(fNode);
            MinimaxTreeNode<char> gNode = new MinimaxTreeNode<char>('G', bNode);
            tree.AddNode(gNode);
            MinimaxTreeNode<char> hNode = new MinimaxTreeNode<char>('H', cNode);
            tree.AddNode(hNode);
            MinimaxTreeNode<char> iNode = new MinimaxTreeNode<char>('I', cNode);
            tree.AddNode(iNode);
            MinimaxTreeNode<char> jNode = new MinimaxTreeNode<char>('J', dNode);
            tree.AddNode(jNode);
            MinimaxTreeNode<char> kNode = new MinimaxTreeNode<char>('K', dNode);
            tree.AddNode(kNode);
            MinimaxTreeNode<char> lNode = new MinimaxTreeNode<char>('L', eNode);
            tree.AddNode(lNode);
            MinimaxTreeNode<char> mNode = new MinimaxTreeNode<char>('M', eNode);
            tree.AddNode(mNode);
            MinimaxTreeNode<char> nNode = new MinimaxTreeNode<char>('N', fNode);
            tree.AddNode(nNode);
            MinimaxTreeNode<char> oNode = new MinimaxTreeNode<char>('O', fNode);
            tree.AddNode(oNode);
            MinimaxTreeNode<char> pNode = new MinimaxTreeNode<char>('P', gNode);
            tree.AddNode(pNode);
            MinimaxTreeNode<char> qNode = new MinimaxTreeNode<char>('Q', gNode);
            tree.AddNode(qNode);
            MinimaxTreeNode<char> rNode = new MinimaxTreeNode<char>('R', hNode);
            tree.AddNode(rNode);
            MinimaxTreeNode<char> sNode = new MinimaxTreeNode<char>('S', hNode);
            tree.AddNode(sNode);
            MinimaxTreeNode<char> tNode = new MinimaxTreeNode<char>('T', iNode);
            tree.AddNode(tNode);
            MinimaxTreeNode<char> uNode = new MinimaxTreeNode<char>('U', iNode);
            tree.AddNode(uNode);
            MinimaxTreeNode<char> vNode = new MinimaxTreeNode<char>('V', jNode);
            tree.AddNode(vNode);
            MinimaxTreeNode<char> wNode = new MinimaxTreeNode<char>('W', jNode);
            tree.AddNode(wNode);
            MinimaxTreeNode<char> xNode = new MinimaxTreeNode<char>('X', kNode);
            tree.AddNode(xNode);
            MinimaxTreeNode<char> yNode = new MinimaxTreeNode<char>('Y', kNode);
            tree.AddNode(yNode);
            return tree;
        }
    }
}
