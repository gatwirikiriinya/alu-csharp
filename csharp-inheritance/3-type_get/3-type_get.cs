using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type objType = myObj.GetType();

        Console.WriteLine($"Properties and methods of {objType.Name}:");

        // Get properties and methods using reflection
        PropertyInfo[] properties = objType.GetProperties();
        MethodInfo[] methods = objType.GetMethods();

        // Print property names
        foreach (var property in properties)
        {
            Console.WriteLine($"Property: {property.Name}");
        }

        // Print method names
        foreach (var method in methods)
        {
            Console.WriteLine($"Method: {method.Name}");
        }
    }
}