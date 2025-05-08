using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        double average = (double)numbers.Sum() / numbers.Length;
        Console.WriteLine("Average: " + average);
    }
}


