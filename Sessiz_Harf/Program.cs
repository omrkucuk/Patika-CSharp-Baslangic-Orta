using System;

class Program
{
    static bool HasConsecutiveConsonants(string word)
    {
        string vowels = "aeıioöuüAEIİOÖUÜ";
        
        for (int i = 0; i < word.Length - 1; i++)
        {
            if (!vowels.Contains(word[i]) && !vowels.Contains(word[i + 1]))
            {
                return true;
            }
        }
        return false;
    }

    static void Main()
    {
        Console.WriteLine("Lütfen bir metin giriniz:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            Console.Write(HasConsecutiveConsonants(word) + " ");
        }
    }
}