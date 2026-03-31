using CybersecurityChatbot;
using System;
using System.Threading;

namespace CybersecurityAwarenessChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Cybersecurity Awareness Chatbot";
            //emoji
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // Display ASCII Logo
            AsciiArt.DisplayLogo();

            // Play Voice Greeting
            AudioPlayer.PlayGreeting();

            Thread.Sleep(500);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Welcome to the Cybersecurity Awareness Bot!");
            Console.ResetColor();

            // Start Chatbot
            Chatbot bot = new Chatbot();
            bot.Start();
        }
    }
}