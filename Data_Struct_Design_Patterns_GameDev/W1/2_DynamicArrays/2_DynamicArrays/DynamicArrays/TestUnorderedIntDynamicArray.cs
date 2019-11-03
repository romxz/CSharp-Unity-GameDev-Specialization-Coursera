using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    /// <remarks>
    /// Test class for UnorderedIntDynamicArray 
    /// </remarks>
    static class TestUnorderedIntDynamicArray
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("UnorderedIntDynamicArray Test Cases");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine();

            // Add method test cases
            TestAddEmptyDynamicArray();
            TestAddExpandDynamicArray();
            Console.WriteLine();

            // Remove method test cases
            TestRemoveEmptyDynamicArray();
            TestRemoveItemFrontOfDynamicArray();
            TestRemoveItemBackOfDynamicArray();
            TestRemoveItemInteriorOfDynamicArray();
            TestRemoveItemNotInDynamicArray();
            Console.WriteLine();

            // IndexOf method test cases
            TestIndexOfEmptyDynamicArray();
            TestIndexOfFrontOfDynamicArray();
            TestIndexOfBackOfDynamicArray();
            Console.WriteLine();

            // Count property test cases
            TestCountEmptyDynamicArray();
            Console.WriteLine();

            // Clear method test cases
            TestClearEmptyDynamicArray();
            TestClearNonemptyDynamicArray();
            Console.WriteLine();
        }

        #region Add method test cases

        /// <summary>
        /// Test adding an item to an empty array
        /// </summary>
        static void TestAddEmptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            System.Console.Write("TestAddEmptyDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("42") &&
                array.Count == 1)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 42 Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test adding an item to an array that needs to be expanded
        /// </summary>
        static void TestAddExpandDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            array.Add(39);
            array.Add(38);
            array.Add(37);
            System.Console.Write("TestAddExpandedDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("42,41,40,39,38,37") &&
                array.Count == 6)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 42,41,40,39,38,37 Actual: " + arrayString);
            }
        }

        #endregion

        #region Remove method test cases

        /// <summary>
        /// Test removing an item from an empty array
        /// </summary>
        static void TestRemoveEmptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            System.Console.Write("TestRemoveEmptyDynamicArray: ");
            if (!array.Remove(42))
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: false Actual: true");
            }
        }

        /// <summary>
        /// Test removing an item at the front of the array
        /// </summary>
        static void TestRemoveItemFrontOfDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            System.Console.Write("TestRemoveItemFrontOfDynamicArray: ");
            bool removed = array.Remove(42);
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("40,41") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 40,41 Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item at the back of the array
        /// </summary>
        static void TestRemoveItemBackOfDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            System.Console.Write("TestRemoveItemBackOfDynamicArray: ");
            bool removed = array.Remove(40);
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("42,41") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 42,41 Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item in the interior of the array
        /// </summary>
        static void TestRemoveItemInteriorOfDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            System.Console.Write("TestRemoveItemInteriorOfDynamicArray: ");
            bool removed = array.Remove(41);
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("42,40") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 42,40 Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item not in the array
        /// </summary>
        static void TestRemoveItemNotInDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            System.Console.Write("TestRemoveItemNotInDynamicArray: ");
            if (!array.Remove(8))
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: false Actual: true");
            }
        }

        #endregion

        #region IndexOf method test cases

        /// <summary>
        /// Test finding the index of an item in an empty array
        /// </summary>
        static void TestIndexOfEmptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            System.Console.Write("TestIndexOfEmptyDynamicArray: ");
            int actualIndex = array.IndexOf(42);
            if (actualIndex == -1)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: -1 Actual: " + actualIndex);
            }
        }

        /// <summary>
        /// Test finding the index of an item at the front of the array
        /// </summary>
        static void TestIndexOfFrontOfDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            System.Console.Write("TestIndexOfFrontOfDynamicArray: ");
            int actualIndex = array.IndexOf(42);
            if (actualIndex == 0)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 0 Actual: " + actualIndex);
            }
        }

        /// <summary>
        /// Test finding the index of an item at the back of the array
        /// </summary>
        static void TestIndexOfBackOfDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            System.Console.Write("TestIndexOfBackOfDynamicArray: ");
            int actualIndex = array.IndexOf(40);
            if (actualIndex == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 2 Actual: " + actualIndex);
            }
        }

        #endregion

        #region Count property test cases

        /// <summary>
        /// Test getting the count for an empty array
        /// </summary>
        static void TestCountEmptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            System.Console.Write("TestCountEmptyDynamicArray: ");
            if (array.Count == 0)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 0 Actual: " + array.Count);
            }
        }

        #endregion

        #region Clear method test cases

        /// <summary>
        /// Test clearing an empty array
        /// </summary>
        static void TestClearEmptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            System.Console.Write("TestClearEmptyDynamicArray: ");
            array.Clear();
            if (array.Count == 0)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 0 Actual: " + array.Count);
            }
        }

        /// <summary>
        /// Test clearing a non-empty array
        /// </summary>
        static void TestClearNonemptyDynamicArray()
        {
            UnorderedIntDynamicArray array = new UnorderedIntDynamicArray();
            array.Add(42);
            array.Add(41);
            array.Add(40);
            array.Add(39);
            array.Add(38);
            array.Add(37);
            System.Console.Write("TestClearNonemptyDynamicArray: ");
            array.Clear();
            if (array.Count == 0)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: 0 Actual: " + array.Count);
            }
        }

        #endregion
    }
}
