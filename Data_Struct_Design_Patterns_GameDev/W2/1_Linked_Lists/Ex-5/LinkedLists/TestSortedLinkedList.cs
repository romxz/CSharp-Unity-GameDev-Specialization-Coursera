using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedLists
{
    /// <remarks>
    /// Test class for SortedLinkedList 
    /// </remarks>
    static class TestSortedLinkedList
    {
        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("------------------------------");
            Console.WriteLine("SortedLinkedList Test Cases");
            Console.WriteLine("------------------------------");
            Console.WriteLine();

            // Add method test cases
            TestAddEmptyLinkedList();
            TestAddFrontOfLinkedList();
            TestAddBackOfLinkedList();
            TestAddInteriorOfLinkedList();
            Console.WriteLine();
        }

        #region Add method test cases

        /// <summary>
        /// Test adding an item to an empty list
        /// </summary>
        static void TestAddEmptyLinkedList()
        {
            SortedLinkedList<string> list = new SortedLinkedList<string>();
            list.Add("Foxtrot");
            Console.Write("TestAddEmptyLinkedList: ");
            string listString = list.ToString();
            if (listString.Equals("Foxtrot") &&
                list.Count == 1)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Foxtrot  and 1 Actual: " + 
                    listString + " and " + list.Count);
            }
        }

        /// <summary>
        /// Test adding an item to the front of a list
        /// </summary>
        static void TestAddFrontOfLinkedList()
        {
            SortedLinkedList<string> list = new SortedLinkedList<string>();
            list.Add("Foxtrot");
            list.Add("Echo");
            Console.Write("TestAddFrontOfLinkedList: ");
            string listString = list.ToString();
            if (listString.Equals("Echo,Foxtrot") &&
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
        /// Test adding an item to the back of the list
        /// </summary>
        static void TestAddBackOfLinkedList()
        {
            SortedLinkedList<string> list = new SortedLinkedList<string>();
            list.Add("Delta");
            list.Add("Echo");
            Console.Write("TestAddBackOfLinkedList: ");
            string listString = list.ToString();
            if (listString.Equals("Delta,Echo") &&
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
        /// Test adding an item to the iterior of the list
        /// </summary>
        static void TestAddInteriorOfLinkedList()
        {
            SortedLinkedList<string> list = new SortedLinkedList<string>();
            list.Add("Delta");
            list.Add("Golf");
            list.Add("Echo");
            list.Add("Foxtrot");
            Console.Write("TestAddInteriorOfLinkedList: ");
            string listString = list.ToString();
            if (listString.Equals("Delta,Echo,Foxtrot,Golf") &&
                list.Count == 4)
            {
                Console.WriteLine("Passed");
            }
            else
            {
                Console.WriteLine("FAILED!!! Expected: Delta,Echo,Foxtrot,Golf and 4 Actual: " + 
                    listString + " and " + list.Count);
            }
        }

        #endregion
    }
}
