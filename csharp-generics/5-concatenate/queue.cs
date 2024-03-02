using System;
using System.Text;

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

    public void Print()
    {
        Node<T> current = head;
        while (current != null)
        {
            Console.WriteLine(current.value);
            current = current.next;
        }
    }

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (typeof(T) != typeof(string) && typeof(T) != typeof(char))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only.");
            return null;
        }

        StringBuilder sb = new StringBuilder();
        Node<T> current = head;
        while (current != null)
        {
            sb.Append(current.value);
            current = current.next;
            if (current != null)
                sb.Append(" ");
        }

        return sb.ToString();
    }
}