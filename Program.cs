using System;

namespace hello_world
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            var currentdate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Helo, {name}, on {currentdate:d} at {currentdate:t}!");
            Console.WriteLine($"{Environment.NewLine}Press any key to exit...");
            Console.ReadKey(true);
        }
    }
}
