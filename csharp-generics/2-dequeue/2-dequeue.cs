using System;

class Node<T>
{
    public T value;
    public Node<T> next;

    public Node(T value)
    {
        this.value = value;
        this.next = null;
    }
}

class Queue<T>
{
    private Node<T> head;
    private Node<T> tail;
    private int count;

    public void Enqueue(T value)
    {
        Node<T> newNode = new Node<T>(value);

        if (head == null)
            head = newNode;
        else
            tail.next = newNode;

        tail = newNode;
        count++;
    }

    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        T value = head.value;
        head = head.next;
        count--;

        return value;
    }

    public int Count()
    {
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("First value: " + myIntQ.Dequeue());
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());

        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        Console.WriteLine("First value: " + myFloatQ.Dequeue());
    }
}
