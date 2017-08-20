using System;

namespace CoreHelloUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name:");
            var userName = Console.ReadLine();
            var dtg = DateTime.Now;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nHello {userName}.  The date/time is {dtg}.");
            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey(true);
        }
    }
}