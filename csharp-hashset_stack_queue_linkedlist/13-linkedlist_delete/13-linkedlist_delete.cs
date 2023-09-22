using System;
using System.Collections.Generic;

public class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        // Check if the index is valid
        if (index < 0 || index >= myLList.Count)
        {
            throw new ArgumentOutOfRangeException("Index is out of range");
        }

        // Find the node at the specified index
        LinkedListNode<int> currentNode = myLList.First;
        for (int i = 0; i < index; i++)
        {
            currentNode = currentNode.Next;
        }

        // Remove the node at the specified index
        myLList.Remove(currentNode);
    }
}
