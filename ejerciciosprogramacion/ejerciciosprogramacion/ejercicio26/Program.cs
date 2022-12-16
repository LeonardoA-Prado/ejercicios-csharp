﻿namespace ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Introduzca un num entero");
                int n = int.Parse(Console.ReadLine());

                int result = Sumatorio(n);
                Console.WriteLine(result);
            }


            static int Sumatorio(int x)
            {
                int result = 0;

                for (int i = 1; i <= x; i++)
                {
                    result += Factorial(i) + i;
                }

                return result;
            }

            static int Factorial(int x)
            {
                int result;

                if (x == 0) result = 1;
                else result = x * Factorial(x - 1);

                return result;
            }
        }
    }
}