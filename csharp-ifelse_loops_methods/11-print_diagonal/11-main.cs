using System;

public class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
        {
            // If length is 0 or less, print just a new line
            Console.WriteLine();
        }
        else
        {
            for (int i = 0; i < length; i++)
            {
                // Print leading spaces
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }

                // Print the backslash and a new line
                Console.WriteLine("\\");
            }
        }
    }
}

class ExecutePrintDiagonal
{
    static void Main(string[] args)
    {
        Line.PrintDiagonal(3);
        Line.PrintDiagonal(0);
        Line.PrintDiagonal(12);
        Line.PrintDiagonal(-98);
    }
}
