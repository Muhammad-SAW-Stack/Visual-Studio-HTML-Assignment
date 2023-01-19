using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWhat is your name?");
            var username = Console.ReadLine();
            Console.WriteLine($"\nHello {username}!");
            DateTime now = DateTime.Now;
            int dayOfYear = now.DayOfYear;

            Console.Write("Day of year: ");
            Console.WriteLine(dayOfYear);
        }
    }
}
