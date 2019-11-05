using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    /// <remarks>
    /// Tests the Stack class
    /// </remarks>
    class TestStack
    {
        // stack to use for testing
        static Stack<int> stack = new Stack<int>();

        /// <summary>
        /// Tests the Stack methods
        /// </summary>
        /// <param name="args">arguments</param>
        static void Main(string[] args)
        {
            // confirm new stack has 0 items
            Console.WriteLine("New stack should have 0 items");
            TestCount(0);
            TestContents("");
            Console.WriteLine();

            // test popping from an empty stack
            Console.WriteLine("Popping from an empty stack should throw an exception");
            TestPopException();
            Console.WriteLine();

            // test peeking at an empty stack
            Console.WriteLine("Peeking at an empty stack should throw an exception");
            TestPeekException();
            Console.WriteLine();

            // test push
            Console.WriteLine("Pushing 42 first");
            TestPush42First();
            Console.WriteLine();
            Console.WriteLine("Pushing 15 second");
            TestPush15Second();
            Console.WriteLine();

            // test peek
            Console.WriteLine("Peeking at top of stack");
            TestPeek();
            Console.WriteLine();

            // test pop
            Console.WriteLine("Popping from the top of the stack");
            TestPop();
            Console.WriteLine();
        }

        #region Private test cases

        /// <summary>
        /// Tests to make sure the number of items in the stack matches the expected value
        /// </summary>
        /// <param name="expected">the expected value</param>
        static void TestCount(int expected)
        {
            int actual = stack.Count;
            if (actual == expected)
            {
                Console.WriteLine("TestCount passed");
            }
            else
            {
                Console.WriteLine("TestCount FAILED! Expected: " + expected +
                    ", actual: " + actual);
            }
        }

        /// <summary>
        /// Test to make sure the stack contents match the expected contents
        /// </summary>
        /// <param name="expected">the expected contents</param>
        static void TestContents(string expected)
        {
            string actual = stack.ToString();
            if (actual == expected)
            {
                Console.WriteLine("TestContents passed");
            }
            else
            {
                Console.WriteLine("TestContents FAILED! Expected: " + expected +
                    ", actual: " + actual);
            }
        }

        /// <summary>
        /// Tests pushing 42 onto the stack as the first item
        /// </summary>
        /// <param name="item">the item to push on the stack</param>
        static void TestPush42First()
        {
            // build expected results
            string expected = "42";
            int expectedCount = stack.Count + 1;

            // push item and check results
            stack.Push(42);
            TestContents(expected);
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests pushing 15 onto the stack as the second item
        /// </summary>
        /// <param name="item">the item to push on the stack</param>
        static void TestPush15Second()
        {
            // build expected results
            string expected = "42,15";
            int expectedCount = stack.Count + 1;

            // push item and check results
            stack.Push(15);
            TestContents(expected);
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests that pop pops from the top of the stack
        /// </summary>
        static void TestPop()
        {
            // build expected results
            int expected = 15;
            int expectedCount = stack.Count - 1;
            string expectedNewStackContents = "42";

            // pop item and check results
            int actual = stack.Pop();
            if (actual == expected)
            {
                Console.WriteLine("TestPop passed");
            }
            else
            {
                Console.WriteLine("TestPop FAILED! Expected: " + expected +
                    ", actual: " + actual);
            }
            TestContents(expectedNewStackContents);
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests that an exception is thrown when popping from an empty stack
        /// </summary>
        static void TestPopException()
        {
            try
            {
                int item = stack.Pop();
                Console.WriteLine("TestPopException FAILED! InvalidOperationException not thrown");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("TestPopException passed");
            }
        }

        /// <summary>
        /// Tests that peek returns the top of the stack
        /// </summary>
        static void TestPeek()
        {
            // build expected results
            int expected = 15;
            int expectedCount = stack.Count;
            string stackContents = "42,15";

            int actual = stack.Peek();
            if (actual == expected)
            {
                Console.WriteLine("TestPeek passed");
            }
            else
            {
                Console.WriteLine("TestPeek FAILED! Expected: " + expected +
                    ", actual: " + actual);
            }
            TestContents(stackContents);
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests that an exception is thrown when peeking at an empty stack
        /// </summary>
        static void TestPeekException()
        {
            try
            {
                int item = stack.Peek();
                Console.WriteLine("TestPeekException FAILED! InvalidOperationException not thrown");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("TestPeekException passed");
            }
        }

        #endregion
    }
}
