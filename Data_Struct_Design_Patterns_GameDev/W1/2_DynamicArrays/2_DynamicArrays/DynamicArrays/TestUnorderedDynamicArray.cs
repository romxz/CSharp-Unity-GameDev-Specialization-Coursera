using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    /// <remarks>
    /// Test class for UnorderedDynamicArray 
    /// </remarks>
    static class TestUnorderedDynamicArray
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("UnorderedDynamicArray Test Cases");
            Console.WriteLine("--------------------------------");
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            System.Console.Write("TestAddEmptyDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("Foxtrot") &&
                array.Count == 1)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Foxtrot Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test adding an item to an array that needs to be expanded
        /// </summary>
        static void TestAddExpandDynamicArray()
        {
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            array.Add("Charlie");
            array.Add("Bravo");
            array.Add("Alpha");
            System.Console.Write("TestAddExpandedDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("Foxtrot,Echo,Delta,Charlie,Bravo,Alpha") &&
                array.Count == 6)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Foxtrot,Echo,Delta,Charlie,Bravo,Alpha Actual: " + arrayString);
            }
        }

        #endregion

        #region Remove method test cases

        /// <summary>
        /// Test removing an item from an empty array
        /// </summary>
        static void TestRemoveEmptyDynamicArray()
        {
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            System.Console.Write("TestRemoveEmptyDynamicArray: ");
            if (!array.Remove("Foxtrot"))
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            System.Console.Write("TestRemoveItemFrontOfDynamicArray: ");
            bool removed = array.Remove("Foxtrot");
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("Delta,Echo") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Delta,Echo Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item at the back of the array
        /// </summary>
        static void TestRemoveItemBackOfDynamicArray()
        {
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            System.Console.Write("TestRemoveItemBackOfDynamicArray: ");
            bool removed = array.Remove("Delta");
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("Foxtrot,Echo") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Foxtrot,Echo Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item in the interior of the array
        /// </summary>
        static void TestRemoveItemInteriorOfDynamicArray()
        {
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            System.Console.Write("TestRemoveItemInteriorOfDynamicArray: ");
            bool removed = array.Remove("Echo");
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("Foxtrot,Delta") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Foxtrot,Delta Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item not in the array
        /// </summary>
        static void TestRemoveItemNotInDynamicArray()
        {
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            System.Console.Write("TestRemoveItemNotInDynamicArray: ");
            if (!array.Remove("Golf"))
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            System.Console.Write("TestIndexOfEmptyDynamicArray: ");
            int actualIndex = array.IndexOf("Foxtrot");
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            System.Console.Write("TestIndexOfFrontOfDynamicArray: ");
            int actualIndex = array.IndexOf("Foxtrot");
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            System.Console.Write("TestIndexOfBackOfDynamicArray: ");
            int actualIndex = array.IndexOf("Delta");
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
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
            UnorderedDynamicArray<String> array = new UnorderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            array.Add("Charlie");
            array.Add("Bravo");
            array.Add("Alpha");
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
