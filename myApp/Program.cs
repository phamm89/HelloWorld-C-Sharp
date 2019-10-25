using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name? ");
            var name = Console.ReadLine();
            var date = DateTime.Now;

            Console.WriteLine($"\nHello, {name}! The current date is {date:d} at {date:t}!");
            Console.WriteLine("\nC# is a great language to learn.");
            Console.Write("\nPress any key to continue...");
            Console.ReadKey(true);
        }
    }
}
