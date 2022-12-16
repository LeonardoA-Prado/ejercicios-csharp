// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce la cantidad de números:");
int cantidad = int.Parse(Console.ReadLine());
double sum = 0;

Console.WriteLine($"Introduce {cantidad} numeros");
for (int i = 0; i < cantidad; i++)
{
    
    sum += double.Parse(Console.ReadLine());
}

double media = sum / cantidad;

Console.WriteLine($"La media es {media}");
