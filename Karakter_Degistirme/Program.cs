using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Lütfen bir metin giriniz:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length > 1)
            {
                char first = words[i][0];
                char last = words[i][words[i].Length - 1];
                string middle = words[i].Substring(1, words[i].Length - 2);
                words[i] = last + middle + first;
            }
        }

        Console.WriteLine(string.Join(" ", words));
    }
}
