namespace ejercicio30
{
    internal class Program
    {
static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número entero");
            int rows = int.Parse(Console.ReadLine());

            for (int i = 1; i <= rows; i++)
            {
                int spaces = rows - i;

                Console.Write(new string(' ', spaces));

                for(int j = 0; j <= i; j++)
                {
                    Console.Write(Combinatorio(i, j));
                    if(j < i) Console.Write(" ");
                }

                Console.WriteLine();
            }
        }

        static int Combinatorio(int m, int n)
        {
            return Factorial(m) / (Factorial(n) * Factorial(m - n));
        }

        static int Factorial(long x)
        {
            int result = 1;

            for (int i = 2; i <= x; i++)
            {
                result *= i; 
            }

            return result;
        }
    }
}