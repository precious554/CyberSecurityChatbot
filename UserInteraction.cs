using System;

public class UserInteraction
{
    public static string GetUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        }

        Console.WriteLine($"\nNice to meet you, {name}!");
        return name;
    }
}