using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    /// <summary>
    /// A queue
    /// </summary>
    /// <typeparam name="T">type for queue elements</typeparam>
    class Queue<T>
    {
        List<T> contents = new List<T>();

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Queue()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of items in the queue
        /// </summary>
        public int Count
        {
            get { return contents.Count; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds an item to the back of the queue
        /// </summary>
        /// <param name="item">the item to add to the queue</param>
        public void Enqueue(T item)
        {
            contents.Add(item);
        }

        /// <summary>
        /// Removes the item from the front of the queue
        /// </summary>
        /// <returns>the removed item</returns>
        public T Dequeue()
        {
            // throw exception if try to dequeue from an empty queue
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't dequeue from an empty queue");
            }
            else
            {
                // retrieve front of queue, remove, and return
                T item = contents[0];
                contents.RemoveAt(0);
                return item;
            }
        }

        /// <summary>
        /// Peeks at the front item on the queue
        /// </summary>
        /// <returns>the front item</returns>
        public T Peek()
        {
            // throw exception if try to peek at an empty queue
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't peek at an empty queue");
            }
            else
            {
                // return front of queue
                return contents[0];
            }
        }

        /// <summary>
        /// Converts the queue to a string
        /// </summary>
        /// <returns>the string</returns>
        public override string ToString()
        {
            StringBuilder contentsString = new StringBuilder();
            for (int i = 0; i < contents.Count; i++)
            {
                contentsString.Append(contents[i]);
                if (i < contents.Count - 1)
                {
                    contentsString.Append(",");
                }
            }
            return contentsString.ToString();
        }

        #endregion
    }
}
