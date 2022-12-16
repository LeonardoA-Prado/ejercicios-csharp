// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce la semilla:");
int semilla = int.Parse(Console.ReadLine());

Console.WriteLine("Introduce la cantidad de caracteeres:");
int cantidad = int.Parse(Console.ReadLine());

Random random = new Random(semilla);

for (int i = 0; i < cantidad; i++)
{
    int ascii = random.Next(256);
    Console.Write((char)ascii);
}
