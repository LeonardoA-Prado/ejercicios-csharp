// See https://aka.ms/new-console-template for more information
Console.WriteLine("introduzca un numero entero:");
int num = int.Parse(Console.ReadLine());

if (num % 2 == 0)
{
    Console.WriteLine("Es par");
}
else if (num % 2 == 1)
{
    Console.WriteLine("Es impar");
}
else
{
    Console.WriteLine("Introduzca un numero valido");
}