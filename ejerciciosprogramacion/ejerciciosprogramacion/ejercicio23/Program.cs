namespace ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Introduce un numero entero");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Introduzca otro numero entero");
                int b = int.Parse(Console.ReadLine());
                int division = a / b;
                Console.WriteLine($"{a} divido por {b} es igual a {division}");
            }
            catch (Exception error)
            {
                Console.WriteLine("Error en la operación: {0}, a");
            }
        }
    }
}