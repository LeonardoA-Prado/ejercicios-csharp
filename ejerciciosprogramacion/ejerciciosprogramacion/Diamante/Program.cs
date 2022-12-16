using System.Text;

namespace Diamante
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringbuilder = new StringBuilder();

            Console.WriteLine("Inserta una cantidad para formar el diamante:");
            int cant = int.Parse(Console.ReadLine());
            int espacios, asteriscos;
            for (int i = 0; i < cant; i++)
            {
                espacios = cant - i;
                asteriscos = 2 * i + 1;



                stringbuilder.Append(new string(' ', espacios));
                stringbuilder.AppendLine(new string('*', asteriscos));

            }
            for (int i = cant - 2; i >= 0; i--)
            {
                espacios = cant - i;
                asteriscos = 2 * i + 1;

                stringbuilder.Append(new string(' ', espacios));
                stringbuilder.AppendLine(new string('*', asteriscos));

            }

            Console.WriteLine(stringbuilder.ToString());
        }
    }
}