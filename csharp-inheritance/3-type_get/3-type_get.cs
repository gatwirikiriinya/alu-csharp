using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"{objType.Name} Properties:");
        foreach (PropertyInfo property in objType.GetProperties())
        {
            Console.WriteLine(property.Name);
        }

        Console.WriteLine($"{objType.Name} Methods:");
        foreach (MethodInfo method in objType.GetMethods())
        {
            Console.WriteLine(method.Name);
        }
    }
}