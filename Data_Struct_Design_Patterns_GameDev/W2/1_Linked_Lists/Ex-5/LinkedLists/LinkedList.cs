using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <remarks>
    /// A linked list of a data type
    /// </remarks>
    abstract class LinkedList<T>
    {
        protected LinkedListNode<T> head;
        protected int count;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        protected LinkedList()
        {
            head = null;
            count = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of nodes in the list
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        /// <summary>
        /// Gets the head of the list
        /// </summary>
        /// <value>head of the list</value>
        public LinkedListNode<T> Head
        {
            get { return head; }
        }

        #endregion

        #region Public methods

        public abstract void Add(T item);

        /// <summary>
        /// Removes all the items from the linked list
        /// </summary>
        public void Clear()
        {
            // unlink all nodes so they can be garbage collected
            if (head != null)
            {
                LinkedListNode<T> previousNode = head;
                LinkedListNode<T> currentNode = head.Next;
                previousNode.Next = null;
                while (currentNode != null)
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                    previousNode.Next = null;
                }
            }

            // reset head and count
            head = null;
            count = 0;
        }

        /// <summary>
        /// Removes the given item from the list
        /// </summary>
        /// <param name="item">item to remove</param>
        public bool Remove(T item)
        {
            // can't remove from an empty list
            if (head == null)
            {
                return false;
            }
            else if (head.Value.Equals(item))
            {
                // remove from head of list
                head = head.Next;
                count--;

                return true;
            }
            else
            {
                LinkedListNode<T> previousNode = head;
                LinkedListNode<T> currentNode = head.Next;
                while (currentNode != null &&
                    !currentNode.Value.Equals(item))
                {
                    previousNode = currentNode;
                    currentNode = currentNode.Next;
                }

                // check for didn't find item
                if (currentNode == null)
                {
                    return false;
                }
                else
                {
                    // set link and reduce count
                    previousNode.Next = currentNode.Next;
                    count--;

                    return true;
                }
            }
        }

        /// <summary>
        /// Finds the given item in the list. Returns null
        /// if the item wasn't found in the list
        /// </summary>
        /// <param name="item">item to find</param>
        public  LinkedListNode<T> Find(T item)
        {
            LinkedListNode<T> currentNode = head;
            while (currentNode != null &&
                !currentNode.Value.Equals(item))
            {
                currentNode = currentNode.Next;
            }

            // return node for item if found
            if (currentNode != null)
            {
                return currentNode;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Converts the linked list to a comma-separated string of values
        /// </summary>
        /// <returns></returns>comma-separated string of values</returns>
        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            LinkedListNode<T> currentNode = head;
            int nodeCount = 0;
            while (currentNode != null)
            {
                nodeCount++;
                builder.Append(currentNode.Value);
                if (nodeCount < count)
                {
                    builder.Append(",");
                }
                currentNode = currentNode.Next;
            }
            return builder.ToString();
        }

        #endregion
    }
}