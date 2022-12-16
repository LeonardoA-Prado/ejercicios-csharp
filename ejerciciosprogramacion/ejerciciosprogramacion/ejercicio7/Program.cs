// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca un número entero:");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca otro número entero:");
int b = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca un tercer número entero:");
int c = int.Parse(Console.ReadLine());

if (a == b && b != c && a == c)
{
    Console.WriteLine("Es isósceles");
}
else if (a == c && b == c && a == b)
{
    Console.WriteLine("Es Equilatáro");
}
else
{
    Console.WriteLine("Es Escaleno");
}
