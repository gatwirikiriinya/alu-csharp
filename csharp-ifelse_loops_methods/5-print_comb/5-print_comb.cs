using System;

class Program 
{
    static void Main(string[] args)
    {
        for(int number = 0 ; number < 100; number++)
        {
            Console.Write(number.ToString("00"));
            if (number != 99)
            {
                Console.Write(", ");
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}
