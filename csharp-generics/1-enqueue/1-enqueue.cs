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

    public int Count()
    {
        return count;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Queue<string> myStrQ = new Queue<string>();

        myStrQ.Enqueue("Hello");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        myStrQ.Enqueue("World");
        Console.WriteLine("Number of nodes in queue: " + myStrQ.Count());

        Console.WriteLine("----------");

        Queue<float> myFloatQ = new Queue<float>();

        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        myFloatQ.Enqueue(4.2f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());

        myFloatQ.Enqueue(-9.8f);
        Console.WriteLine("Number of nodes in queue: " + myFloatQ.Count());
    }
}
