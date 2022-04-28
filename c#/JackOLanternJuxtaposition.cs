using System;
using System.Linq;

namespace JackOLanternJuxtaposition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] designs = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            Console.WriteLine(designs.Aggregate((total, next) => total * next));
        }
    }
}
