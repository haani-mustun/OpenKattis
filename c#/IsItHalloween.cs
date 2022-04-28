using System;

namespace IsItHalloween
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] MonthAndDay = Console.ReadLine().Split(' ');
            switch (MonthAndDay[0])
            {
                case "OCT":
                    if (MonthAndDay[1] == "31")
                    {
                        Console.WriteLine("yup");
                    }
                    else
                    {
                        Console.WriteLine("nope");
                    }
                    break;
                case "DEC":
                    if (MonthAndDay[1] == "25")
                    {
                        Console.WriteLine("yup");
                    }
                    else
                    {
                        Console.WriteLine("nope");
                    }
                    break;
                default:
                    Console.WriteLine("nope");
                    break;
            }
        }
    }
}
