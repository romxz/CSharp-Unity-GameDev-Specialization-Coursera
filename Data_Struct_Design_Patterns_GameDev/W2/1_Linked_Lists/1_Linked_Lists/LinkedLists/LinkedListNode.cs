using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists {
    /// <summary>
    /// A linked list node
    /// </summary>
    class LinkedListNode<T> {
        #region Fields

        // Note: Autoproperties
        //T value;
        //LinkedListNode<T> next;

        #endregion

        #region Constructors

        /// <summary>
        /// Creates new node with given value and next node
        /// </summary>
        /// <param name="value">value</param>
        /// <param name="next">next node</param>
        public LinkedListNode(T value, LinkedListNode<T> next) {
            this.Value = value;
            this.Next = next;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the node value
        /// </summary>
        /// <value>node value</value>
        public T Value { get; private set; }

        /// <summary>
        /// Gets and sets the next node
        /// </summary>
        /// <value>next node</value>
        public LinkedListNode<T> Next { get; set; }

        #endregion
    }
}