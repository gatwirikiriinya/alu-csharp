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

    public T Peek()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return default(T);
        }

        return head.value;
    }

    public int Count()
    {
        return count;
    }
}
