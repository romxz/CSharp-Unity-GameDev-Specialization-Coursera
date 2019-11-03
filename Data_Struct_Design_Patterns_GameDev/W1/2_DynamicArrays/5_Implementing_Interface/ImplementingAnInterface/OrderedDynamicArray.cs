using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingAnInterface
{
    /// <remarks>
    /// An ordered DynamicArray
    /// </remarks>
    class OrderedDynamicArray<T> : DynamicArray<T> where T : IComparable
    {
        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        public OrderedDynamicArray()
            : base()
        {
        }

        #endregion

        #region Public methods

        /// <summary>
        /// Adds the given item to the IntDynamicArray
        /// </summary>
        /// <param name="item">the item to add</param>
        public override void Add(T item)
        {
            // expand array if necessary
            if (count == items.Length)
            {
                Expand();
            }

            // find location at which to add the item
            int addLocation = 0;
            while ((addLocation < count) &&
                (items[addLocation].CompareTo(item) < 0))
            {
                addLocation++;
            }

            // shift array, add new item and increment count
            ShiftUp(addLocation);
            items[addLocation] = item;
            count++;
        }

        /// <summary>
        /// Removes the first occurence of the given item from the IntDynamicArray
        /// </summary>
        /// <param name="item">the item to remove</param>
        /// <returns>true if the item is successfully removed, false otherwise</returns>
        public override bool Remove(T item)
        {
            // check for given item in array
            int itemLocation = IndexOf(item);
            if (itemLocation == -1)
            {
                return false;
            }
            else
            {
                // shift all the elements above the removed one down and change count
                ShiftDown(itemLocation + 1);
                count--;
                return true;
            }
        }

        /// <summary>
        /// Determines the index of the given item using binary search
        /// </summary>
        /// <param name="item">the item to find</param>
        /// <returns>the index of the item or -1 if it's not found</returns>
        public override int IndexOf(T item)
        {
            int lowerBound = 0;
            int upperBound = count - 1;
            int location = -1;

            // second part of Boolean expression added from defect discussed in reading
            // loop until found value or exhausted array
            while ((location == -1) &&
                (lowerBound <= upperBound))
            {
                // find the middle
                int middleLocation = lowerBound + (upperBound - lowerBound) / 2;
                T middleValue = items[middleLocation];

                // check for match
                if (middleValue.CompareTo(item) == 0)
                {
                    location = middleLocation;
                }
                else
                {
                    // split data set to search appropriate side
                    if (middleValue.CompareTo(item) > 0)
                    {
                        upperBound = middleLocation - 1;
                    }
                    else
                    {
                        lowerBound = middleLocation + 1;
                    }

                    // if statement no longer necessary when second part of while loop Boolean expression included
                    // check to see if the array is exhausted
                    //if (lowerBound > upperBound)
                    //{
                    //    break;
                    //}
                }
            }
            return location;
        }

        #endregion

        #region Private methods

        /// <summary>
        /// Shifts all the array elements from the given index to the end of the array up one space
        /// </summary>
        /// <param name="index">the index at which to start shifting up</param>
        private void ShiftUp(int index)
        {
            for (int i = count; i > index; i--)
            {
                items[i] = items[i - 1];
            }
        }

        /// <summary>
        /// Shifts all the array elements from the given index to the end of the array down one space
        /// </summary>
        /// <param name="index">the index at which to start shifting down</param>
        private void ShiftDown(int index)
        {
            for (int i = index; i < count; i++)
            {
                items[i - 1] = items[i];
            }
        }

        #endregion
    }
}
