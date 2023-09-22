using System;
using System.Collections.Generic;

public class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        // Check if the LinkedList is empty
        if (myLList.First == null)
        {
            // Return 0 if the list is empty
            return 0;
        }

        // Get the value of the head node
        int headValue = myLList.First.Value;

        // Remove the head node from the LinkedList
        myLList.RemoveFirst();

        // Return the value of the removed head node
        return headValue;
    }
}