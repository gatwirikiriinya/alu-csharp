using System;

public class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
        {
            // If length is 0 or less, print just a new line
            Console.WriteLine();
        }
        else
        {
            // Print the specified number of underscores followed by a new line
            Console.WriteLine(new string('_', length));
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Line.PrintLine(3);
        Line.PrintLine(0);
        Line.PrintLine(12);
        Line.PrintLine(-98);
    }
}
