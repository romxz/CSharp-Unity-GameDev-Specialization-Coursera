using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    /// <remarks>
    /// Provides a dynamically-sized array of integers
    /// </remarks>
    abstract class IntDynamicArray
    {
        const int ExpandMultiplyFactor = 2;
        protected int[] items;
        protected int count;

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        protected IntDynamicArray()
        {
            items = new int[4];
            count = 0;
        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets the number of elements
        /// </summary>
        public int Count
        {
            get { return count; }
        }

        #endregion

        #region Public methods

        public abstract void Add(int item);
        public abstract bool Remove(int item);
        public abstract int IndexOf(int item);

        /// <summary>
        /// Removes all the items from the IntDynamicArray
        /// </summary>
        public void Clear()
        {
            count = 0;
        }

        /// <summary>
        /// Converts the IntDynamicArray to a comma-separated string of
        /// values
        /// </summary>
        /// <returns>the comma-separated string of values</returns>
        public override String ToString()
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                builder.Append(items[i]);
                if (i < count - 1)
                {
                    builder.Append(",");
                }
            }
            return builder.ToString();
        }

        #endregion

        #region Protected methods

        /// <summary>
        /// Expands the array
        /// </summary>
        protected void Expand()
        {
            int[] newItems = new int[items.Length * ExpandMultiplyFactor];

            // copy elements from old array into new array
            for (int i = 0; i < items.Length; i++)
            {
                newItems[i] = items[i];
            }

            // change to use new array
            items = newItems;
        }

        #endregion
    }
}
