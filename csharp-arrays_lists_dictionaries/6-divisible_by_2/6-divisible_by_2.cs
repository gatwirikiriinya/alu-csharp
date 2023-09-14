using System;
using System.Collections.Generic;

public class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {

        List<bool> result = new List<bool>(myList.Count);

        for (int i = 0; i < myList.Count; i++)
        {
            bool isMultipleBy2 = (myList[i] % 2 == 0);
            result.Add(isMultipleBy2);
        }

        return result;
    }
}