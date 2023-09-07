using System;

class Program
{
    static void Main(string[] args)
    {
        Random rndm = new Random();
        int number = rndm.Next(-10000, 10000);
        string numberString = number.ToString();
        int lastdigit = int.Parse(numberString.Substring(numberString.Length - 1, 1));

        Console.Write("The last digit of " + number + " is " + lastdigit + " and is ");

        if (lastdigit > 5)
            Console.WriteLine("greater than 5");
        else if (lastdigit == 0)
            Console.WriteLine("0");
        else if (lastdigit < 6)
            Console.WriteLine("less than 6 and not 0");
    }
}
