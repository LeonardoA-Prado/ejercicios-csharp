namespace ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un número entero:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca otro numero entero");
            int m = int.Parse(Console.ReadLine());

            int resultado = Factorial(n) - Factorial(m);

            Console.WriteLine($"{n}! - {m}! es igual a {resultado}");
        }

        static int Factorial(int numero)
        {
            int factorial;
            if (numero <= 1)
            {
                factorial = 1;
            }
            else
            {
                factorial = numero * Factorial(numero - 1);
            }
            return factorial;
        }
    }
}