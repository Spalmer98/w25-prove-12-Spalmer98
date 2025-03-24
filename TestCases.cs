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
        item.Enqueue(6);

        Console.WriteLine($"Size: {item.Size()}");

        item.GetItem();
        // Expected output:
        // Size: 6
        // 1
        // 2
        // 3
        // 4
        // 5
        // 6

        Console.WriteLine("==== Test Case 2 ====");
        // Add then remove item from queue
        item = new LLQueue<int>();
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.Enqueue(4);
        item.Enqueue(5);
        item.GetItem();

        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        item.Dequeue();
        Console.WriteLine(item.Dequeue());
        Console.WriteLine(item.Dequeue());
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
        // Add item then peek at the first item in queue
        item = new LLQueue<int>();
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.Enqueue(4);
        item.Enqueue(5);
        item.GetItem();
        Console.WriteLine(item.Peek());
        item.Dequeue();
        item.Dequeue();
        Console.WriteLine(item.Peek());
        item.DequeueAll();
        Console.WriteLine(item.Peek());
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
        // Add item then check to see if the queue contains an item
        item = new LLQueue<int>();
        item.Enqueue(1);
        item.Enqueue(2);
        item.Enqueue(3);
        item.GetItem();

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
        PerformanceMeasurement.MeasurePerformance();
    }
}