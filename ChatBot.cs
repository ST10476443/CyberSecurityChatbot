using System;
using System.Threading;

namespace CybersecurityChatbot
{
    public class Chatbot
    {
        private string userName;

        public void Start()
        {
            AskName();
            ChatLoop();
        }

        private void AskName()
        {
            Console.Write("Enter your name: ");
            userName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userName))
            {
                userName = "User";
            }

            BotResponse($"Hello {userName}! I am your Cybersecurity Assistant.");
        }

        private void ChatLoop()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\nYou: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input))
                {
                    BotResponse("Please enter a valid question.");
                    continue;
                }

                if (input.Contains("how are you"))
                {
                    BotResponse("I'm functioning perfectly and ready to help!");
                }
                else if (input.Contains("purpose"))
                {
                    BotResponse("My purpose is to teach cybersecurity awareness.");
                }
                else if (input.Contains("what can i ask"))
                {
                    BotResponse("You can ask me about:");
                    BotResponse("• Password safety");
                    BotResponse("• Phishing");
                    BotResponse("• Safe browsing");
                }
                else if (input.Contains("password"))
                {
                    BotResponse("Use strong passwords with letters, numbers, and symbols.");
                }
                else if (input.Contains("phishing"))
                {
                    BotResponse("Never click suspicious email links.");
                }
                else if (input.Contains("safe browsing"))
                {
                    BotResponse("Only visit secure websites starting with HTTPS.");
                }
                else if (input.Contains("exit"))
                {
                    BotResponse("Goodbye! Stay safe online.");
                    break;
                }
                else
                {
                    BotResponse("I didn’t quite understand that. Could you rephrase?");
                }
            }
        }

        private void BotResponse(string message)
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("[BOT] ");
            Console.Write("typing");

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(300);
                Console.Write(".");
            }

            Thread.Sleep(300);
            Console.WriteLine();

            Console.Write("[BOT] ");
            TypingEffect(message);

            Console.ResetColor();
        }

        private void TypingEffect(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(35);
            }
            Console.WriteLine();
        }
    }
}
