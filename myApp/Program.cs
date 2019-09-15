using System;

namespace myApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("The current time is " + DateTime.Now);
            Console.Write("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
