namespace ejercicio36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce numeros enteros separados por comas:");

            string numeros = Console.ReadLine();

            string[] numerosDivididos = numeros.Split(',');

            int[] numerosDeVerdad = new int[numerosDivididos.Length];

            for (int i = 0; i < numerosDeVerdad.Length; i++)
            {
                numerosDeVerdad[i] = int.Parse(numerosDivididos[i]);
            }

            int aux;

            for (int i = 0; i < numerosDeVerdad.Length - 1; i++)
            {
                for (int j = 0; j < numerosDeVerdad.Length - 1; j++)
                {
                    if (numerosDeVerdad[i] > numerosDeVerdad[j + 1])
                    {
                        aux = numerosDeVerdad[i];
                        numerosDeVerdad[j] = numerosDeVerdad[j + 1];
                        numerosDeVerdad[j + 1] = aux;
                    }
                }
            }

            Console.WriteLine(string.Join(",", numerosDeVerdad));
        }
    }
}