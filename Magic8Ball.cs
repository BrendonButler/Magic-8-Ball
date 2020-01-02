using System;

namespace Magic8Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Write("What is your question?\r\n> ");
                string input = Console.ReadLine();
                if (input.ToLower().Equals("exit")) break;
            } while (true);
        }
    }
}