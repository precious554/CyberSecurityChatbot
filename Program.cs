using System;

class Program
{
    static void Main()
    {
       
        VoiceGreeting.PlayVoice();

        AsciiArt.DisplayLogo();

        string name = UserInteraction.GetUserName();

        Console.WriteLine($"\nHello {name}, welcome to cybersecurity awareness chatbot!");
        Console.WriteLine("You can ask me about cybersecurity.\n");

        Chatbot bot = new Chatbot();

        while (true)
        {
            Console.Write("\nYou: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Please enter something.");
                continue;
            }

            if (input == "exit")
                break;

            bot.Respond(input);
        }
    }
}
