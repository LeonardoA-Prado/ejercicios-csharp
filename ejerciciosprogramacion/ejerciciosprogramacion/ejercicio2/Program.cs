// See https://aka.ms/new-console-template for more information
using System.Globalization;

CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

Console.WriteLine("Introduzca un numero real:");
double b = double.Parse(Console.ReadLine());

Console.WriteLine("Introduzca otro numero real:");
double a = double.Parse(Console.ReadLine());

double resultado = a + b;
Console.WriteLine($"La suma de {a} + {b} es {resultado}");
