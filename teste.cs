using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, x;
            int I;
            I = 1;

            while (I <= 4)
            {
                Console.Write("Digite um número:");
                a = double.Parse(Console.ReadLine());
                x = a * 3;
                Console.WriteLine("" + x);
                I++;


            }

            Console.ReadLine();


        }
    }
}
