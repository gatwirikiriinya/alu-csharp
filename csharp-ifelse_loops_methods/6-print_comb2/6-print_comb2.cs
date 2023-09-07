using System;

class Program
{
    static void Main(string[] args)
    {
        string result = "";

        for (int firstDigit = 0; firstDigit <= 8; firstDigit++)
        {
            for (int secondDigit = firstDigit + 1; secondDigit <= 9; secondDigit++)
            {
                result += firstDigit.ToString("D1") + secondDigit.ToString("D1") + ", ";
            }
        }

        result = result.TrimEnd(new char[] { ',', ' ' });
        Console.WriteLine(result);
    }
}
