using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen integer çiftlerini boşlukla ayırarak giriniz:");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        if (numbers.Length % 2 != 0)
        {
            Console.WriteLine("Hatalı giriş! Lütfen çift sayıda değer giriniz.");
            return;
        }

        for (int i = 0; i < numbers.Length; i += 2)
        {
            int num1 = int.Parse(numbers[i]);
            int num2 = int.Parse(numbers[i + 1]);
            int sum = num1 + num2;

            if (num1 == num2)
                Console.Write($"{sum * sum} ");
            else
                Console.Write($"{sum} ");
        }
    }
}
