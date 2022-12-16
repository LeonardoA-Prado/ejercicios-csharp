namespace ejercicio29
{
    internal class Program
    {
        enum monedas { Dolares, Libras, Yenes }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca la moneda que quieres convertir(Libras, Dolares, Yenes:");
            monedas moneda = (monedas)Enum.Parse(typeof(monedas), Console.ReadLine(), true);

            if (moneda == monedas.Dolares)
            {
                Console.WriteLine("Introduce los euros para pasar a dolares");
                double numd = double.Parse(Console.ReadLine());
                double resultadod = Dolares(numd);
                Console.WriteLine($"{numd} euros es igual a {resultadod} dolares");
            }

            else if (moneda == monedas.Libras)
            {
                Console.WriteLine("Introduce los euros para pasar a Libra");
                double numl = double.Parse(Console.ReadLine());
                double resultadol = Libras(numl);
                Console.WriteLine($"{numl} euros es igual a {resultadol} libras");
            }

            else
            {
                Console.WriteLine("Introduce los euros para pasar a Yenes");
                double numy = double.Parse(Console.ReadLine());
                double resultadoy = Yenes(numy);
                Console.WriteLine($"{numy} euros es igual a {resultadoy} yenes");
            }
        }

        static double Dolares(double dolare)
        {
            double dolar = dolare * 1.28611;
            return dolar;

        }

        static double Libras(double libra)
        {
            double librare = libra * 0.86;
            return librare;

        }
        static double Yenes(double yene)
        {
            double yened = yene * 129.852;
            return yened;

        }
    }
}