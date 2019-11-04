using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <remarks>
    /// Test class for UnsortedLinkedList 
    /// </remarks>
    static class TestUnsortedLinkedList
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("UnsortedLinkedList Test Cases");
            Console.WriteLine("--------------------------------");
            Console.WriteLine();

            // Add method test cases
            TestAddEmptyLinkedList();
            TestAddNonemptyLinkedList();
            Console.WriteLine();

            // Remove method test cases
            TestRemoveFromEmptyLinkedList();
            TestRemoveItemFromFrontOfLinkedList();
            TestRemoveItemFromBackOfLinkedList();
            TestRemoveItemFromInteriorOfLinkedList();
            TestRemoveItemNotInLinkedList();
            Console.WriteLine();

            // Find method test cases
            TestFindInEmptyLinkedList();
            TestFindAtFrontOfLinkedList();
            TestFindAtBackOfLinkedList();
            Console.WriteLine();

            // Count property test cases
            TestCountEmptyLinkedList();
            Console.WriteLine();

            // Clear method test cases
            TestClearEmptyLinkedList();
            TestClearNonemptyLinkedList();
            Console.WriteLine();
        }

        #region Add method test cases

        /// <summary>
        /// Test adding an item to an empty linked list
        /// </summary>
        static void TestAddEmptyLinkedList()
        {
            LinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            Console.Write("TestAddEmptyLinkedList: ");
            string liststring = list.ToString();
            if (liststring.Equals("Foxtrot") &&
                list.Count == 1)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Foxtrot and 1 Actual: " + 
                    liststring + " and " + list.Count);
            }
        }

        /// <summary>
        /// Test adding an item to a nonempty linked list
        /// </summary>
        static void TestAddNonemptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            Console.Write("TestAddNonemptyLinkedList: ");
            string liststring = list.ToString();
            if (liststring.Equals("Echo,Foxtrot") &&
                list.Count == 2)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Echo,Foxtrot and 2 Actual: " + 
                    liststring + " and " + list.Count);
            }
        }

        #endregion

        #region Remove method test cases

        /// <summary>
        /// Test removing an item from an empty list
        /// </summary>
        static void TestRemoveFromEmptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            Console.Write("TestRemoveFromEmptyLinkedList: ");
            if (!list.Remove("Foxtrot"))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: false Actual: true");
            }
        }

        /// <summary>
        /// Test removing an item from the front of the list
        /// </summary>
        static void TestRemoveItemFromFrontOfLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            Console.Write("TestRemoveItemFromFrontOfLinkedList: ");
            bool removed = list.Remove("Delta");
            string listString = list.ToString();
            if (removed &&
                listString.Equals("Echo,Foxtrot") &&
                list.Count == 2)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Echo,Foxtrot and 2 Actual: " + 
                    listString + " and " + list.Count);
            }
        }

        /// <summary>
        /// Test removing an item from the back of the list
        /// </summary>
        static void TestRemoveItemFromBackOfLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            Console.Write("TestRemoveItemFromBackOfLinkedList: ");
            bool removed = list.Remove("Foxtrot");
            string listString = list.ToString();
            if (removed &&
                listString.Equals("Delta,Echo") &&
                list.Count == 2)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Delta,Echo and 2 Actual: " + 
                    listString + " and " + list.Count);
            }
        }

        /// <summary>
        /// Test removing an item from the interior of the list
        /// </summary>
        static void TestRemoveItemFromInteriorOfLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            Console.Write("TestRemoveItemInteriorOfLinkedList: ");
            bool removed = list.Remove("Echo");
            string listString = list.ToString();
            if (removed &&
                listString.Equals("Delta,Foxtrot") &&
                list.Count == 2)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Delta,Foxtrot and 2 Actual: " + 
                    listString + " and " + list.Count);
            }
        }

        /// <summary>
        /// Test removing an item not in the list
        /// </summary>
        static void TestRemoveItemNotInLinkedList()
        {
            UnsortedLinkedList<string> array = new UnsortedLinkedList<string>();
            array.Add("Foxtrot");
            Console.Write("TestRemoveItemNotInLinkedList: ");
            if (!array.Remove("Golf"))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: false Actual: true");
            }
        }

        #endregion

        #region Find method test cases

        /// <summary>
        /// Test finding the item in an empty list
        /// </summary>
        static void TestFindInEmptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            Console.Write("TestFindInEmptyLinkedList: ");
            LinkedListNode<string> actualNode = list.Find("Foxtrot");
            if (actualNode == null)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: null Actual: " + actualNode.Value);
            }
        }

        /// <summary>
        /// Test finding the item at the front of the list
        /// </summary>
        static void TestFindAtFrontOfLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            Console.Write("TestFindAtFrontOfLinkedList: ");
            LinkedListNode<string> actualNode = list.Find("Foxtrot");
            if (actualNode != null &&
                actualNode.Value.Equals("Foxtrot"))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                if (actualNode == null)
                {
                    Console.WriteLine("FAILED!!! Expected: Foxtrot Actual: null");
                }
                else
                {
                    Console.WriteLine("FAILED!!! Expected: Foxtrot Actual: " +
                        actualNode.Value);
                }
            }
        }

        /// <summary>
        /// Test finding the item at the back of the alinked list
        /// </summary>
        static void TestFindAtBackOfLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            Console.Write("TestFindAtBackOfLinkedList: ");
            LinkedListNode<string> actualNode = list.Find("Delta");
            if (actualNode != null &&
                actualNode.Value.Equals("Delta"))
            {
                Console.WriteLine("Passed");
            }
            else
            {
                if (actualNode == null)
                {
                    Console.WriteLine("FAILED!!! Expected: Delta Actual: null");
                }
                else
                {
                    Console.WriteLine("FAILED!!! Expected: Delta Actual: " +
                        actualNode.Value);
                }
            }
        }

        #endregion

        #region Count property test cases

        /// <summary>
        /// Test getting the count for an empty array
        /// </summary>
        static void TestCountEmptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            Console.Write("TestCountEmptyLinkedList: ");
            if (list.Count == 0)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 0 Actual: " + list.Count);
            }
        }

        #endregion

        #region Clear method test cases

        /// <summary>
        /// Test clearing an empty linked list
        /// </summary>
        static void TestClearEmptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            Console.Write("TestClearEmptyLinkedList: ");
            list.Clear();
            if (list.Count == 0 &&
                list.Head == null)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 0 and null Actual: " +
                    list.Count + " and " + list.Head);
            }
        }

        /// <summary>
        /// Test clearing a non-empty linked list
        /// </summary>
        static void TestClearNonemptyLinkedList()
        {
            UnsortedLinkedList<string> list = new UnsortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            list.Add("Delta");
            list.Add("Charlie");
            list.Add("Bravo");
            list.Add("Alpha");
            Console.Write("TestClearNonemptyLinkedList: ");
            list.Clear();
            if (list.Count == 0 &&
                list.Head == null)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: 0 and null Actual: " +
                    list.Count + " and " + list.Head);
            }
        }

        #endregion
    }
}
