using System;
using System.Collections.Generic;

public class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);

        // If the LinkedList is empty, simply add the new node as the first node.
        if (myLList.First == null)
        {
            myLList.AddFirst(newNode);
            return newNode;
        }

        // Iterate through the LinkedList to find the correct position to insert the new node.
        LinkedListNode<int> currentNode = myLList.First;
        while (currentNode != null)
        {
            // Compare the current node's value with the new value.
            // If the current node's value is greater than the new value, insert before it.
            if (currentNode.Value > n)
            {
                myLList.AddBefore(currentNode, newNode);
                return newNode;
            }

            // Move to the next node.
            currentNode = currentNode.Next;
        }

        // If we reach the end of the LinkedList, add the new node at the end.
        myLList.AddLast(newNode);
        return newNode;
    }
}
