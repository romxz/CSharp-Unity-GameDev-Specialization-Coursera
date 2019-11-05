using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    /// <remarks>
    /// A stack
    /// </remarks>
    class Stack<T>
    {
        List<T> contents = new List<T>();

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public Stack()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of items in the stack
        /// </summary>
        public int Count
        {
            get { return contents.Count; }
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Pushes the item on the stack
        /// </summary>
        /// <param name="item"></param>
        public void Push(T item)
        {
            contents.Add(item);
        }

        /// <summary>
        /// Pops the top item from the stack
        /// </summary>
        /// <returns>the popped item</returns>
        public T Pop()
        {
            // throw exception if try to pop from an empty stack
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't pop from an empty stack");
            }
            else
            {
                // retrieve top of stack, remove, and return
                T item = contents[contents.Count - 1];
                contents.RemoveAt(contents.Count - 1);
                return item;
            }
        }

        /// <summary>
        /// Peeks at the top item on the stack
        /// </summary>
        /// <returns>the top item</returns>
        public T Peek()
        {
            // throw exception if try to peek at an empty stack
            if (contents.Count == 0)
            {
                throw new InvalidOperationException("Can't peek at an empty stack");
            }
            else
            {
                // return top of stack
                return contents[contents.Count - 1];
            }
        }

        /// <summary>
        /// Converts the stack to a string
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
