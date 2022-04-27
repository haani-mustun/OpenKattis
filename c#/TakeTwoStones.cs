using System;

namespace TakeTwoStones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine((int.Parse(Console.ReadLine()) % 2 == 0) ? "Bob" : "Alice");
        }
    }
}
