using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArrays
{
    /// <remarks>
    /// Test class for OrderedDynamicArray 
    /// </remarks>
    static class TestOrderedDynamicArray
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("OrderedDynamicArray Test Cases");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // Add method test cases
            TestAddEmptyDynamicArray();
            TestAddExpandDynamicArray();
            TestAddBackOfDynamicArray();
            TestAddInteriorOfDynamicArray();
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
        }

        #region Add method test cases

        /// <summary>
        /// Test adding an item to an empty array
        /// </summary>
        static void TestAddEmptyDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
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
        /// Test adding an item to an array that needs to be expanded. Also tests adding an item at
        /// the beginning of the array
        /// </summary>
        static void TestAddExpandDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Foxtrot");
            array.Add("Echo");
            array.Add("Delta");
            array.Add("Charlie");
            array.Add("Bravo");
            array.Add("Alpha");
            System.Console.Write("TestAddExpandedDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("Alpha,Bravo,Charlie,Delta,Echo,Foxtrot") &&
                array.Count == 6)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Alpha,Bravo,Charlie,Delta,Echo,Foxtrot Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test adding an item to the back of the array
        /// </summary>
        static void TestAddBackOfDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestAddBackOfDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("Delta,Echo,Foxtrot") &&
                array.Count == 3)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Delta,Echo,Foxtrot Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test adding an item to the iterior of the array
        /// </summary>
        static void TestAddInteriorOfDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Foxtrot");
            array.Add("Echo");
            System.Console.Write("TestAddInteriorOfDynamicArray: ");
            String arrayString = array.ToString();
            if (arrayString.Equals("Delta,Echo,Foxtrot") &&
                array.Count == 3)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Delta,Echo,Foxtrot Actual: " + arrayString);
            }
        }

        #endregion

        #region Remove method test cases

        /// <summary>
        /// Test removing an item from an empty array
        /// </summary>
        static void TestRemoveEmptyDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
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
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestRemoveItemFrontOfDynamicArray: ");
            bool removed = array.Remove("Delta");
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("Echo,Foxtrot") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Echo,Foxtrot Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item at the back of the array
        /// </summary>
        static void TestRemoveItemBackOfDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestRemoveItemBackOfDynamicArray: ");
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
        /// Test removing an item in the interior of the array
        /// </summary>
        static void TestRemoveItemInteriorOfDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestRemoveItemInteriorOfDynamicArray: ");
            bool removed = array.Remove("Echo");
            String arrayString = array.ToString();
            if (removed &&
                arrayString.Equals("Delta,Foxtrot") &&
                array.Count == 2)
            {
                System.Console.WriteLine("Passed");
            }
            else
            {
                System.Console.WriteLine("FAILED!!! Expected: Delta,Foxtrot Actual: " + arrayString);
            }
        }

        /// <summary>
        /// Test removing an item not in the array
        /// </summary>
        static void TestRemoveItemNotInDynamicArray()
        {
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
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
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
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
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestIndexOfFrontOfDynamicArray: ");
            int actualIndex = array.IndexOf("Delta");
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
            OrderedDynamicArray<String> array = new OrderedDynamicArray<String>();
            array.Add("Delta");
            array.Add("Echo");
            array.Add("Foxtrot");
            System.Console.Write("TestIndexOfBackOfDynamicArray: ");
            int actualIndex = array.IndexOf("Foxtrot");
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
    }
}
