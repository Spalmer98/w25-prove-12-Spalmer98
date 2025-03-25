using System.Runtime.CompilerServices;

namespace prove_12;

public class TestCases
{
    public static void Run()
    {
        Console.WriteLine("================== Test Cases ==================\n");

        Console.WriteLine("==== Test Case 1 ====");
        // Add items to queue and check if full   
        var item = new LLQueue<int>();
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.Enqueue(4);
        item.Enqueue(5);

        Console.WriteLine($"Size: {item.Size()}");

        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }
        // Expected output:
        // Size: 5
        // 1
        // 2
        // 3
        // 4
        // 5

        Console.WriteLine("==== Test Case 2 ====");
        // Remove item from queue returning the removed item to the console. Remove another item this time with no return before 
        // removing another item with a return. Repeat this one more times before removing the rest of the items and triggering
        // the try/catch statement that posts "Queue is empty." to the console.
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }

        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        try
        {
            Console.WriteLine(item.Dequeue());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Expected output:
        // 1
        // 2
        // 3
        // 4
        // 5 
        // 1
        // 3
        // 5
        // Queue is empty.

        Console.WriteLine("==== Test Case 3 ====");
        // Add items then peek at the first item in queue, then remove two more items and peek at the next item before removing
        // the rest of the items and triggering the try/catch statment.
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.Enqueue(4);
        item.Enqueue(5);
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }
        Console.WriteLine(item.Peek());
        item.Dequeue();
        item.Dequeue();
        Console.WriteLine(item.Peek());
        while(item.Size() != 0)
        {
            item.Dequeue();
        }
        try
        {
            Console.WriteLine(item.Peek());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        // Expected output:
        // 1
        // 2
        // 3
        // 4
        // 5 
        // 1
        // 3
        // Queue is empty.

        Console.WriteLine("==== Test Case 4 ====");
        // Add items to queue and display all the items in the queue, then check to see if the queue contains specific items. 
        // Remove one of the items from the queue and check for it again.
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        for(int i = 0; i < item.Size(); i++)
        {
            Console.WriteLine(item.toString(i));
        }

        Console.WriteLine(item.Contains(3));
        Console.WriteLine(item.Contains(4));
        Console.WriteLine(item.Contains(1));
        item.Dequeue();
        Console.WriteLine(item.Contains(1));
        // Expected output:
        // 1
        // 2
        // 3
        // True
        // False
        // True
        // False

        Console.WriteLine("==== Test Case 5 ====");
        // Performance tests to calculate speed of each main function's execution.
        Console.WriteLine("==== Performance Test 10 Items ====");
        PerformanceMeasurement.MeasurePerformance10();
        Console.WriteLine();
        Console.WriteLine("==== Performance Test 100 Items ====");
        PerformanceMeasurement.MeasurePerformance100();
        Console.WriteLine();
        Console.WriteLine("==== Performance Test 1,000 Items ====");
        PerformanceMeasurement.MeasurePerformance1000();
        Console.WriteLine();
        Console.WriteLine("==== Performance Test 10,000 Items ====");
        PerformanceMeasurement.MeasurePerformance10000();
        Console.WriteLine();
        Console.WriteLine("==== Performance Test 100,000 Items ====");
        PerformanceMeasurement.MeasurePerformance100000();
        Console.WriteLine();
        Console.WriteLine("==== Performance Test 1,000,000 Items ====");
        PerformanceMeasurement.MeasurePerformance1000000();
    }
    /// <summary>
    /// Based on the performance tests I can clearly see that Enqueue, Peek, and Dequeu are all O(1) complexity because they maintain
    /// a consistance execution speed until the items reach 1,000,000 where they begin to jump to double digit speeds.
    /// 
    /// The Contains function on the other hand appears to be an O(n) complexity because it's execution time clearly increases as the
    /// number of items/inputs increases. Once we reach 1,000,000 items we see a massive spike in time it takes to execute and causes
    /// the program to take a considerable amount of time to progress.
    /// </summary>
}
