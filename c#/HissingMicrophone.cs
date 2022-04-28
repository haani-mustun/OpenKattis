using System;

namespace HissingMicrophone
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int i;  

            for (i = 0; i < input.Length; i++)
            {
                if (input[i] == 's' && i < input.Length - 1)
                {
                    if (input[i + 1] == 's')
                    {
                        Console.WriteLine("hiss");
                        break;
                    }
                    else
                    {
                        i += 1;
                    }
                }
            }

            if (i == input.Length)
            {
                Console.WriteLine("no hiss");
            }
        }
    }
}
