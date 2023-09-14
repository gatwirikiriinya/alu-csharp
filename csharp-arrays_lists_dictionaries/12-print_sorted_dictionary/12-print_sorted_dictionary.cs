using System;
using System.Collections.Generic;

public class Dictionary
{
    public static void PrintSorted(Dictionary<string,string> myDict)
    {
        List<string> sortedKeys = new List<string>(myDict.Keys);
        sortedKeys.Sort();

        foreach ( string key in sortedKeys)
        {
            string value = myDict[key];
            Console.WriteLine($"{key}: {value}");
        }
    }
}