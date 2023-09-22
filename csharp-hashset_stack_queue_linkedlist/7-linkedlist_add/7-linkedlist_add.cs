using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Add(LinkedList<int> myLList, int n)
    {
        // Create a new node with the specified value
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // Insert the new node at the beginning of the LinkedList
        myLList.AddFirst(newNode);

        // Return the newly added node
        return newNode;
    }
}
