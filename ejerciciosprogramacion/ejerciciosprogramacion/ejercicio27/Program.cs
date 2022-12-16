namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Introduzca 2 numeros enteros:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = Fibonacci(a) + Fibonacci(b);
            Console.WriteLine(result);
        }

        static int Fibonacci(int x)
        {
            int result;

            if (x == 0)
            {
                result = 0;
            }
            else if (x == 1)
            {
                result = 1;
            }
            else
            {
                result = Fibonacci(x - 1) + Fibonacci(x - 2);
            }

            return result;
        }
    }
}