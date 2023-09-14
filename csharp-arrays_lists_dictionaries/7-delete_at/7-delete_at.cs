﻿using System;
using System.Collections.Generic;

public class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= 0 && index < myList.Count)
        {
            List<int> updatedList = new List<int>();

            for (int i = 0; i < myList.Count; i++)
            {
                if (i != index)
                {
                    updatedList.Add(myList[i]);
                }
            }

            return updatedList;
        }
        else
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }


    }
}