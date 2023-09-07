using System;

public class Number
{
    public static int PrintLastDigit(int number)
    {
        string result = "";

        // Calculate the absolute value to handle negative numbers
        int absoluteValue = Math.Abs(number);

        // Extract and append the last digit to the result
        result += (absoluteValue % 10);

        // Return the last digit as an integer
        return int.Parse(result);
    }
}

class Program
{
    static void Main(string[] args)
    {
        int r;

        Number.PrintLastDigit(98);
        Number.PrintLastDigit(0);
        r = Number.PrintLastDigit(-1024);
        Console.WriteLine(r);
    }
}
