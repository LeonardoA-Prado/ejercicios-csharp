namespace ejercicio35
{
    internal class Program
    {
        const string LETRAS = "TRWAGMYFPDXBNJZSQVHLCKE";
        static void Main(string[] args)
        {
            Console.WriteLine("Dime tu numero dni:");

            int dni = int.Parse(Console.ReadLine());
            char letra = LETRAS[dni % LETRAS.Length];

            Console.WriteLine("Tu dni es {0}{1}", dni, letra);
        }
    }
}