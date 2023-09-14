using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        if (myDict.ContainsKey(key))
        {
            myDict[key] = value; // If the key exists, replace the value
        }
        else
        {
            myDict[key] = value; // If the key doesn't exist, create it
        }

        return myDict;
    }
}