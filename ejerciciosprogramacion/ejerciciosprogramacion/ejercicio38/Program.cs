namespace ejercicio38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next();
                if (i % 2 != 0)
                {
                    Console.WriteLine($"posicion: {i} se ha generado {array[i]}");
                }
            }
        }
    }
}