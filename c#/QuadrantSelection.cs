using System;

namespace QuadrantSelection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool PositiveX = int.Parse(Console.ReadLine()) < 0 ? false : true;
            bool PositiveY = int.Parse(Console.ReadLine()) < 0 ? false : true;

            switch (PositiveX)
            {
                case true:
                    switch (PositiveY)
                    {
                        case true:
                            Console.WriteLine("1");
                            break;
                        case false:
                            Console.WriteLine("4");
                            break;
                    }
                    break;
                case false:
                    switch (PositiveY)
                    {
                        case true:
                            Console.WriteLine("2");
                            break;
                        case false:
                            Console.WriteLine("3");
                            break;
                    }
                    break;
            }
        }
    }
}
