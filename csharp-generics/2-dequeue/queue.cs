using System;

/// <summary>
/// Represents a generic queue class.
/// </summary>
/// <typeparam name="T">The type of elements stored in the queue.</typeparam>
public class Queue<T>
{
    /// <summary>
    /// Represents a node in the queue.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// Gets or sets the value of the node.
        /// </summary>
        public T? Value { get; set; }
        
        /// <summary>
        /// Gets or sets the reference to the next node.
        /// </summary>
        public Node? Next { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Node"/> class with the specified value.
        /// </summary>
        /// <param name="value">The value of the node.</param>
        public Node(T value)
        {
            Value = value;
            Next = null;
        }
    }

    /// <summary>
    /// Represents the first node in the queue.
    /// </summary>
    protected Node? head;

    /// <summary>
    /// Represents the last node in the queue.
    /// </summary>
    protected Node? tail;

    /// <summary>
    /// Represents the count of elements in the queue.
    /// </summary>
    private int count;

    /// <summary>
    /// Initializes a new instance of the <see cref="Queue{T}"/> class.
    /// </summary>
    public Queue()
    {
        head = null;
        tail = null;
        count = 0;
    }

    /// <summary>
    /// Adds an element to the end of the queue.
    /// </summary>
    /// <param name="value">The value to enqueue.</param>
    public void Enqueue(T value)
    {
        Node newNode = new Node(value);

        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            tail!.Next = newNode;
            tail = newNode;
        }

        count++;
    }

    /// <summary>
    /// Removes and returns the element at the beginning of the queue.
    /// </summary>
    /// <returns>The element removed from the beginning of the queue.</returns>
    public T? Dequeue()
    {
        T? currentValue;

        if (count == 0)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }
        else
        {
            count--;
            currentValue = head!.Value;
            head = head.Next;
        }

        return currentValue;
    }

    /// <summary>
    /// Gets the type of elements stored in the queue.
    /// </summary>
    /// <returns>The type of elements stored in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }

    /// <summary>
    /// Gets the number of elements in the queue.
    /// </summary>
    /// <returns>The number of elements in the queue.</returns>
    public int Count()
    {
        return count;
    }
}
