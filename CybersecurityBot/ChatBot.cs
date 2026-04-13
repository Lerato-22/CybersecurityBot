using System;
using System.Speech.Synthesis;
using static System.Console;

namespace CybersecurityBot
{
    internal class ChatBot
    {
        // Stores the user's name
        public string UserName { get; set; }

        public ChatBot(string name)
        {
            UserName = name;
        }

        // Greets the user by name using text to speech
        public void SpeakGreeting()
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Rate = -1;
            voice.Volume = 100;
            voice.Speak("Hey " + UserName + "! Welcome to the Cybersecurity Awareness Bot. " +
                         "I am here to help you stay safe online.");
        }

        // Main chat loop where the user interacts with the bot
        public void StartChat()
        {
            bool running = true;

            while (running)
            {
                Display.PrintDivider();
                ForegroundColor = ConsoleColor.White;
                Write("  [" + UserName + "] > ");
                ResetColor();

                string input = ReadLine();

                // Check if the user typed nothing
                if (input == "")
                {
                    ForegroundColor = ConsoleColor.DarkYellow;
                    Display.TypeLine("  Eish! You did not type anything. Please ask me a question!");
                    ResetColor();
                    continue;
                }

                input = input.ToLower().Trim();

                // Check if the user wants to exit
                if (input.Contains("exit") || input.Contains("bye") || input.Contains("quit"))
                {
                    ForegroundColor = ConsoleColor.Cyan;
                    Display.TypeLine("\n  Sala kahle " + UserName + "! Stay safe out there. \n");
                    ResetColor();
                    running = false;
                    continue;
                }

                // Get the response from the Responses class
                var (message, color) = Responses.GetResponse(input, UserName);

                // If the bot does not understand the input
                if (message == "__UNKNOWN__")
                {
                    ForegroundColor = ConsoleColor.DarkYellow;
                    Display.TypeLine("\n  Hmm, I am not sure what you mean. Try rephrasing?");
                    Display.TypeLine("  Type 'help' to see all the topics I can help you with.\n");
                    ResetColor();
                }
                else
                {
                    Display.PrintResponse(message, color);
                }
            }
        }
    }
}