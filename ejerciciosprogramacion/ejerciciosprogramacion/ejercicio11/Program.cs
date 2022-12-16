// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce un número entero:");
int num = int.Parse(Console.ReadLine());

for (int i = 2; i <= num; i++) 
{
    bool esPrimo = true;

    for (int j = 2; j <= i / 2 && esPrimo; j++)
    {
        if (i % j == 0) esPrimo = false;
    }

    if (esPrimo)
    {
        Console.WriteLine(i);
    }
}
