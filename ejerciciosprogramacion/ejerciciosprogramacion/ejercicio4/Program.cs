// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca un numero entero de 2 o más cifras:");
int num = int.Parse(Console.ReadLine());

int unidad = num % 10;

Console.WriteLine($"La unidad de {num} es {unidad}");
