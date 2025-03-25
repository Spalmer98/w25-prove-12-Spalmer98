using System.Diagnostics;
namespace prove_12;

public class PerformanceMeasurement
{
    private static LLQueue<int> queue = new LLQueue<int>();
    private static Stopwatch stopwatch = new Stopwatch();

    /// <summary>
    /// Measuring performance of 10 items
    /// </summary>
    public static void MeasurePerformance10()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 10; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 10; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }


    /// <summary>
    /// Measuring performance of 100 items
    /// </summary>
    public static void MeasurePerformance100()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 100; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 100; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }


    /// <summary>
    /// Measuring performance of 1,000 items
    /// </summary>
    public static void MeasurePerformance1000()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 1000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 1000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }


    /// <summary>
    /// Measuring performance of 10,000 items
    /// </summary>
    public static void MeasurePerformance10000()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 10000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 10000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }


    /// <summary>
    /// Measuring performance of 100,000 items
    /// </summary>
    public static void MeasurePerformance100000()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 100000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 100000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }


    /// <summary>
    /// Measuring performance of 1,000,000 items
    /// </summary>
    public static void MeasurePerformance1000000()
    {
        // Measure Enqueue
        stopwatch.Start();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Enqueue(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Enqueue Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Peek
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Peek();
        }
        stopwatch.Stop();
        Console.WriteLine("Peek Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Contains
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Contains(i);
        }
        stopwatch.Stop();
        Console.WriteLine("Contains Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure Dequeue
        stopwatch.Restart();
        for (int i = 0; i < 1000000; i++)
        {
            queue.Dequeue();
        }
        stopwatch.Stop();
        Console.WriteLine("Dequeue Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}