using System;

class Program
{
    static void Main()
    {
        int[,] array = new int[5,5];

        for (int row = 0; row < 5; row++)
        {
            for(int col = 0 ; col < 5; col++)
            {
                array[row,col] = 0;
            }
        }

        array[2,2] = 1;

        for (int row = 0; row < 5; row++)
        {
            for (int col = 0; col < 5; col++)
            {
                Console.Write(array[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}