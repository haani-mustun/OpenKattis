using System;

namespace FYI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string areaCode = Console.ReadLine().Substring(0, 3);
            if (areaCode == "555")
            {
                Console.WriteLine("1");
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
