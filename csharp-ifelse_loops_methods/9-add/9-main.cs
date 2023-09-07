using System;

public class Number
{
    public static int Add(int a, int b)
    {
        // Calculate the sum of a and b
        int sum = a + b;

        // Return the result
        return sum;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("{0}", Number.Add(1, 2));
        Console.WriteLine("{0}", Number.Add(98, 0));
        Console.WriteLine("{0}", Number.Add(100, -2));
    }
}
