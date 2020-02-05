using System;
using System.Linq;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
                Console.WriteLine("No name provided. Bye");
            else
            {
                Console.WriteLine($"Woooow, {args.Aggregate((res, current) => res += $" {current}")} knows how to use Docker");
            }

            Thread.Sleep(TimeSpan.FromSeconds(5));
        }
    }
}
