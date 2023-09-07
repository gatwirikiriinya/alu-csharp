using System;

class Program
{
    static void Main(string[] args)
    {

        string alphabet = "";

        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            alphabet += letter;
        }

        Console.Write(alphabet);
    }
}