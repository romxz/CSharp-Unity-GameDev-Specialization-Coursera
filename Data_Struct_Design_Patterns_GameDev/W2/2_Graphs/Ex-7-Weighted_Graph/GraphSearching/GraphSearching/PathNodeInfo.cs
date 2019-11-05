using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSearching {
    /// <summary>
    /// Info about a node along a search path
    /// </summary>
    /// <typeparam name="T">type stored in graph node</typeparam>
    class PathNodeInfo<T> {
        #region Fields

        GraphNode<T> previous;
        int weight;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates an info node with the given previous node
        /// </summary>
        /// <param name="previous">previous node in path</param>
        public PathNodeInfo(GraphNode<T> previous, int weight) {
            this.previous = previous;
            this.weight = weight;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the previous graph node in the path
        /// </summary>
        public GraphNode<T> Previous {
            get { return previous; }
        }

        public int Weight {
            get { return weight; }
        }
        #endregion
    }
}
