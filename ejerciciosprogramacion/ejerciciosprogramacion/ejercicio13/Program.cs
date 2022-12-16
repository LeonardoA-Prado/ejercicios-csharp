// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca un numero entero:");

int num = int.Parse(Console.ReadLine());
Random random = new Random();
bool match = false;

for (int i = 0; i < 5; i++)
{
    int randomNum = random.Next(1, num + 1);

    Console.WriteLine(randomNum);

    if (randomNum == num && !match)
    {
        Console.WriteLine("El numero coincide");
        match = true;
    }
}