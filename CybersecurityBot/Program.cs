using System;
using static System.Console;

namespace CybersecurityBot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Show logo
            Display.ShowLogo();

            // Ask for the user's name
            ForegroundColor = ConsoleColor.Magenta;
            Display.TypeText("\n  Welcome! Please enter your name to get started: ");
            ResetColor();

            string name = ReadLine();

            // Validate that the name is not empty
            while (name == "")
            {
                ForegroundColor = ConsoleColor.Red;
                Display.TypeText("  The name can't be empty. Please enter your name: ");
                ResetColor();
                name = ReadLine();
            }

            ChatBot bot = new ChatBot(name);

            // Speak personalised greeting using the user's name
            bot.SpeakGreeting();

            ForegroundColor = ConsoleColor.Green;
            Display.TypeLine("\n  Welcome, " + name + "! I'm your Cybersecurity Awareness Bot.");
            Display.TypeLine("  Type 'help' to see what I can assist you with.\n");
            ResetColor();

            bot.StartChat();

            ReadLine();
        }
    }
}