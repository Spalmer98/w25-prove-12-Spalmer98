using System.Linq.Expressions;

namespace prove_12;

public class LLQueue<T> where T: new()
{
    // Create Variable
    private LinkedList<T> _queue = new LinkedList<T>();
    private int _size;

    // Establish variable data.
    public LLQueue()
    {
        _size = 0;
    }
    
    // Add item to Queue
    public void Enqueue (T item)
    {
        _queue.AddLast(item);
        _size++;
    }

    // Removes an item from the queue and returns the value of the removed item.
    public object Dequeue() 
    {
        // If the _front variable and _rear variable are the same that means the queue is empty so throw an exception to the terminal.
        if (_size == 0)
        {
            Console.WriteLine("Queue is empty.");
            return null;
        }
        else
        {
            // put the item at the front of the queue into a temp variable and then change the location of the frot of the queue to
            // simulate removing the item, finally return the temp variable.
            T item = _queue.First();
            _queue.RemoveFirst();
            _size--;
            return item;
        }
    }

    public void DequeueAll()
    {
        if (_size != 0)
        {
            while(_size != 0)
            {
                _queue.RemoveFirst();
                _size--;
            }
        }
        else
        {
            Console.WriteLine("Queue is empty.");
        }
    }

    // Looks at the item at the front of the queue.
    public object Peek()
    {
        // If the _front variable and _rear variable are the same that means the queue is empty so throw an exception to the terminal.
        if (_size == 0)
        {
            Console.WriteLine("Queue is empty.");
            return null;
        }
        else
        {
            // Return the item at the front of the queue.
            return _queue.First();
        }
    }

    // Check to see if the queue contains a certain item then return it.
    public bool Contains(T item)
    {
        bool results = false;
        if (_queue.Contains(item))
            results = true;
        return results;
    }

    // Gets all items from the queue fron front to back.
    public void GetItem()
    {
        // If the _size is zero that means the queue is empty so throw an exception to the terminal.
        if(_size == 0)
        {
            Console.WriteLine("Queue is empty.");
        }
        else
        {
            // Loop through every item in the queue starting from the front and ending at the back.
            for(int i = 0; i < _size; i++)
            {
                    Console.WriteLine(_queue.ElementAt(i));
            }
        }
    }

    // Checks with the _size variable to see if the queue is empty.
    public bool IsEmpty()
    {
        return _size == 0;
    }

    // Gets the value from _size variable.
    public int Size()
    {
        return _size;
    }

    private object ReturnNull()
    {
        return "Queue is full.";
    }
}