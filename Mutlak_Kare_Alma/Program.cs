using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen sayıları boşlukla ayırarak giriniz:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int sumSmall = 0, sumLarge = 0;
        int threshold = 67;

        foreach (string num in numbers)
        {
            int value = int.Parse(num);
            int diff = Math.Abs(value - threshold);
            
            if (value < threshold)
                sumSmall += diff;
            else
                sumLarge += diff * diff;
        }

        Console.WriteLine($"{sumSmall} {sumLarge}");
    }
}