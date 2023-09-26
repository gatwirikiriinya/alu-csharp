using System;
using System.Collections.Generic;

public class ListUtility
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        try
        {
            for (int i = 0; i < listLength; i++)
            {
                int element1 = i < list1.Count ? list1[i] : 0;
                int element2 = i < list2.Count ? list2[i] : 0;

                if (element2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero");
                    resultList.Add(0);
                }
                else
                {
                    int result = element1 / element2;
                    resultList.Add(result);
                }
            }
        }
        catch (ArgumentOutOfRangeException)
        {
            Console.WriteLine("Out of range");
        }

        return resultList;
    }
}