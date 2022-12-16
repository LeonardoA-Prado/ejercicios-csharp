namespace ejercicio32
{
    internal class Program
    {
        const int cant = 10;
        static void Main(string[] args)
        {
            int[] numbers = new int[cant];
            CrearArray(numbers);


            //int[] numbers = CrearArray();

            Mostrar(numbers);
        }

        static void CrearArray(int[] numbers)
        {
            for (int i = 0; i < cant; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
        }

        static int[] CrearArray()
        {
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            return numbers;
        }

        static void Mostrar(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(i + " => " + numbers[i]);
                Console.WriteLine($"{i} => {numbers[i]}");
            }
        }
    }
}
