using System;
using System.Collections.Generic;

public class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> resultList = new List<int>();

        int divided = 0;

        for (int i = 0; i < listLength; i++)
        {
            try
            {
                divided = list1[i] / list2[i];
                resultlist.Add(divided);
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                resultlist.Add(0);
            }
        }

        return resultlist;
    }
}