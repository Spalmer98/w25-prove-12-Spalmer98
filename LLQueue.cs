namespace prove_12;

public class LLQueue<T>
{
    // Create a LinkedList for the queue and a variable to keep track of queue size
    private LinkedList<T> _queue = new LinkedList<T>();
    private int _size;

    // Establish variable data.
    public LLQueue()
    {
        _size = 0;
    }
    
    // Add item to Queue and increment the size to corresponding to the increase of items in the queue
    public void Enqueue (T item)
    {
        _queue.AddLast(item);
        _size++;
    }

    // Removes an item from the front of the queue and returns the value of the removed item. Reduce the value of _size to correspond
    // to the removal of an item from the queue. Using the RemoveFirst function in the LinkedList library we can remove the first item
    // in the queue and move the pointer to the next item.
    public T Dequeue() 
    {
        // If _size variable is zero that means the queue is empty so throw an exception to the terminal.
        if (IsEmpty())
        {
            throw new Exception("Queue is empty.");
        }
        else
        {
            // put the item at the front of the queue into a temp variable and then change the location of the front of the queue to
            // simulate removing the item, finally return the temp variable.
            T item = _queue.First();
            _queue.RemoveFirst();
            _size--;
            return item;
        }
    }

    // Looks at the item at the front of the queue.
    public T Peek()
    {
        // If the _front variable and _rear variable are the same that means the queue is empty so throw an exception to the terminal.
        if (IsEmpty())
        {
            throw new Exception("Queue is empty.");
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
        return _queue.Contains(item);
    }

    // Gets all items from the queue fron front to back.
    public String toString(int i)
    {
        // Convert item in _queue to a string and return it.
        return $"{_queue.ElementAt(i)}";
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
}