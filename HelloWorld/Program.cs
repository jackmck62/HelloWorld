using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name...");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Press any key to exit.");
            Console.ReadKey(true);
        }
    }
}
