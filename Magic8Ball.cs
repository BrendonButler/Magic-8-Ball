using System;
using System.Collections.Generic;
using System.Linq;

namespace Magic8Ball
{
    class Program
    {
        private static Random rand = new Random();

        static void Main(string[] args)
        {
            do
            {
                Console.Write("What is your question?\r\n> ");
                string input = Console.ReadLine();
                if (input.ToLower().Equals("exit")) break;
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine(GetResponse() + "\n");
                Console.ResetColor();
            } while (true);
        }

        private static string GetResponse()
        {
            List<string> responses = new List<string>() { "It is certain", "It is decidedly so", "Without a doubt", "Yes - definitely", "You man rely on it", "As I see it, yes", "Most likely", "Outlook good", "Yes", "Signs point to yes", "Reply hazy, try again", "Ask again later", "Better not tell you now", "Cannot predict now", "Concentrate and ask again", "Don't count on it", "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful" };

            return responses[rand.Next(responses.Count())];
        }
    }
}