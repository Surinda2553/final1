using System;

namespace final1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = new int[3, 3];
            Console.WriteLine("Input the arrays:");
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write("{0} : ", i);
                    numbers[i, x] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(numbers[i, x] + " ");
                }
                Console.WriteLine("");
            }
           Console.ReadLine();

        }
    }
}