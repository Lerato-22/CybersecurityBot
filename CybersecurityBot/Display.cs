using System;
using System.Threading;
using static System.Console;

namespace CybersecurityBot
{
    internal class Display
    {
        // Shows the ASCII art logo when the app starts
        public static void ShowLogo()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            WriteLine(@"
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ ██████╗  ██████╗ ████████╗
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗██╔══██╗██╔═══██╗╚══██╔══╝
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝██████╔╝██║   ██║   ██║   
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗██╔══██╗██║   ██║   ██║   
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║██████╔╝╚██████╔╝   ██║   
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝╚═════╝  ╚═════╝    ╚═╝  
  ══════════════════════════════════════════════════════════════════════
         Cybersecurity Awareness Bot — Keeping SA Safe Online 
  ══════════════════════════════════════════════════════════════════════
            ");
            ResetColor();

            // Small pause so the logo stays on screen for a moment
            Thread.Sleep(1500);
        }

        // Prints text one character at a time to create a typing effect
        public static void TypeText(string text, int delay = 5)
        {
            foreach (char c in text)
            {
                Write(c);
                Thread.Sleep(delay);
            }
        }

        // Same as TypeText but moves to a new line at the end
        public static void TypeLine(string text, int delay = 20)
        {
            foreach (char c in text)
            {
                Write(c);
                Thread.Sleep(delay);
            }
            WriteLine();
        }

        // Prints the bot response inside a neat formatted box
        public static void PrintResponse(string message, ConsoleColor color)
        {
            WriteLine();
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("  ┌─[  CyberBot ]────────────────────────────────────┐");

            // Small pause to make it feel like the bot is thinking
            Thread.Sleep(400);

            ForegroundColor = color;
            foreach (string line in message.Split('\n'))
            {
                Write("  │  ");
                TypeText(line, 15);
                WriteLine();
                Thread.Sleep(30);
            }

            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("  └────────────────────────────────────────────────────┘");
            ResetColor();
            WriteLine();
        }

        // Prints a divider line between each chat message
        public static void PrintDivider()
        {
            ForegroundColor = ConsoleColor.DarkMagenta;
            WriteLine("  ──────────────────────────────────────────────────────");
            ResetColor();
        }
    }
}