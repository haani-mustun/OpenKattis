using System;

namespace Greetings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string receivingHey = Console.ReadLine();
            int numberOfEs = (receivingHey.Length - receivingHey.Replace("e", string.Empty).Length) * 2;
            string sendingHey = "h";
            for (int i = 0; i < numberOfEs; i++)
            {
                sendingHey += "e";
            }
            Console.WriteLine(sendingHey + "y");
        }
    }
}
