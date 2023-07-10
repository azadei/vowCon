using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string: ");
        string input = Console.ReadLine();

        int vowel = 0;
        int conso = 0;

        foreach (char c in input.ToLower())
        {
            if (Char.IsLetter(c))
            {
                if ("aeiou".Contains(c))
                    vowel++;
                else
                    conso++;
            }
        }

        Console.WriteLine("Vowels: " + vowel);
        Console.WriteLine("Consonants: " + conso);
    }
}