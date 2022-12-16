namespace ejercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
             int[] numeros = new int[100];
           
            int result = 0; 


            for (int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = i + 1;
            }

            foreach(int num in numeros)
            {
                result += num;
            }

         int media = result / numeros.Length;
            Console.WriteLine($"Media: {media}");
        }
    }
}