using System;
using System.Collections.Generic;

public class Chatbot
{
    Dictionary<string, string> responses = new Dictionary<string, string>()
    {
        {"how are you", "I am functioning perfectly!"},
        {"what is your purpose", "I help you stay safe online."},
        {"what can i ask you about", "You can ask about passwords, phishing, or safe browsing."},
        {"password", "Use strong passwords with uppercase, lowercase, numbers, and symbols."},
        {"phishing", "Avoid clicking suspicious links or emails."},
        {"safe browsing", "Always check if a website starts with https."}
    };

    public void Respond(string input)
    {
        if (responses.ContainsKey(input))
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("CyberBot: " + responses[input]);
            Console.ResetColor();
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("CyberBot: I didn't quite understand that. Could you rephrase?");
            Console.WriteLine("Always log out when you done!");
            Console.ResetColor();
        }
    }
}
