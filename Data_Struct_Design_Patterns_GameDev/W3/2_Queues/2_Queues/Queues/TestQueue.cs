using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queues
{
    /// <remarks>
    /// Tests the Queue class
    /// </remarks>
    static class TestQueue
    {
        // queue to use for testing
        static Queue<int> queue = new Queue<int>();

        /// <summary>
        /// Driver method for test cases
        /// </summary>
        public static void RunTestCases()
        {
            Console.WriteLine("----------------");
            Console.WriteLine("Queue Test Cases");
            Console.WriteLine("----------------");
            Console.WriteLine();

            // confirm new queue has 0 items
            Console.WriteLine("New queue should have 0 items");
            TestCount(0);
            TestContents("");
            Console.WriteLine();

            // test dequeueing from an empty queue
            Console.WriteLine("Dequeueing from an empty queue should throw an exception");
            TestDequeueException();
            Console.WriteLine();

            // test peeking at an empty queue
            Console.WriteLine("Peeking at an empty queue should throw an exception");
            TestPeekException();
            Console.WriteLine();

            // test enqueue
            Console.WriteLine("Enqueueing 42 first");
            TestEnqueue(42);
            Console.WriteLine();
            Console.WriteLine("Enqueueing 15 second");
            TestEnqueue(15);
            Console.WriteLine();
            Console.WriteLine("Enqueueing 33 third");
            TestEnqueue(33);
            Console.WriteLine();

            // test peek
            Console.WriteLine("Peeking at front of queue");
            TestPeek();
            Console.WriteLine();

            // test dequeue
            Console.WriteLine("Dequeueing from the front of the queue");
            TestDequeue();
            Console.WriteLine();
        }

        #region Private test cases

        /// <summary>
        /// Tests to make sure the number of items in the queue matches the expected value
        /// </summary>
        /// <param name="expected">the expected value</param>
        static void TestCount(int expected)
        {
            int actual = queue.Count;
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
        /// Test to make sure the queue contents match the expected contents
        /// </summary>
        /// <param name="expected">the expected contents</param>
        static void TestContents(string expected)
        {
            string actual = queue.ToString();
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
        /// Tests enqueueing an item on the queue
        /// </summary>
        /// <param name="item">the item to add to the queue</param>
        static void TestEnqueue(int item)
        {
            // build expected results
            string expected;
            if (queue.Count == 0)
            {
                expected = item.ToString();
            }
            else
            {
                expected = queue.ToString() + "," + item;
            }
            int expectedCount = queue.Count + 1;

            // enqueue item and check results
            queue.Enqueue(item);
            Console.WriteLine("New queue: " + queue.ToString());
            TestContents(expected);
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests that dequeue removes the item from the front of the queue
        /// </summary>
        static void TestDequeue()
        {
            // build expected results
            string[] tokens = queue.ToString().Split(',');
            int expected = Int32.Parse(tokens[0]);
            int expectedCount = queue.Count - 1;
            StringBuilder expectedNewQueueContents = new StringBuilder();
            for (int i = 1; i < tokens.Length; i++)
            {
                expectedNewQueueContents.Append(tokens[i]);
                if (i < tokens.Length - 1)
                {
                    expectedNewQueueContents.Append(",");
                }
            }

            // dequeue item and check results
            int actual = queue.Dequeue();
            Console.WriteLine("New queue: " + queue.ToString());
            Console.WriteLine("Dequeue value: " + actual);
            if (actual == expected)
            {
                Console.WriteLine("TestDequeue passed");
            }
            else
            {
                Console.WriteLine("TestDequeue FAILED! Expected: " + expected +
                    ", actual: " + actual);
            }
            TestContents(expectedNewQueueContents.ToString());
            TestCount(expectedCount);
        }

        /// <summary>
        /// Tests that an exception is thrown when dequeueing from an empty queue
        /// </summary>
        static void TestDequeueException()
        {
            try
            {
                int item = queue.Dequeue();
                Console.WriteLine("TestDequeueException FAILED! InvalidOperationException not thrown");
            }
            catch (InvalidOperationException ioe)
            {
                Console.WriteLine("TestDequeueException passed");
            }
        }

        /// <summary>
        /// Tests that peek returns the front of the queue
        /// </summary>
        static void TestPeek()
        {
            // build expected results
            string[] tokens = queue.ToString().Split(',');
            int expected = Int32.Parse(tokens[0]);
            int expectedCount = queue.Count;
            string stackContents = queue.ToString();

            int actual = queue.Peek();
            Console.WriteLine("Peek value: " + actual);
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
        /// Tests that an exception is thrown when peeking at an empty queue
        /// </summary>
        static void TestPeekException()
        {
            try
            {
                int item = queue.Peek();
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
