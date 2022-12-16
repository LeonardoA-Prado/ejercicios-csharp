using System.Globalization;

namespace ejercicio28
{
    internal class Program
    {
        enum Option { Circle, Triangle, Square };
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Elige opcion (Circulo = 0, Triangulo = 1, Cuadrado = 2):");
            //Console.WriteLine("Elige opcion(Circulo, Triangulo, Cuadrado):");

            Option option = (Option)int.Parse(Console.ReadLine());

            double area = 0;
            switch (option)
            {
                case Option.Circle:
                    area = CalcularCirculo();
                    break;

                case Option.Triangle:
                    area = CalcularTriangulo();
                    break;

                case Option.Square:
                    area = CalcularCuadrado();
                    break;

            }
            Console.WriteLine(area);
        }

        static double CalcularCirculo()
        {

            Console.WriteLine("Introduce el radio del circulo:");

            double radio = double.Parse(Console.ReadLine());

            return Math.PI * Math.Pow(radio, 2);

        }

        static double CalcularTriangulo()
        {


            Console.WriteLine("Introduce la base del triangulo:");
            double @base = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura");
            double altura = double.Parse(Console.ReadLine());


            return @base * altura / 2;
        }

        static double CalcularCuadrado()
        {
            Console.WriteLine("Introduce el lado del cuadrado:");
            double lado = double.Parse(Console.ReadLine());

            return lado * lado;
        }
    }
}