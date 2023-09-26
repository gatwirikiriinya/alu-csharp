﻿using System.Collections

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int printedCount = 0;

        try
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                printedCount++;
            }
        }
        catch (System.Exception)
        {
            return printedCount;

        }

        return printedCount;
    }
}

