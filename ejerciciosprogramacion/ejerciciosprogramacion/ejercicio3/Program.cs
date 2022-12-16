// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca una temperatura en Fahrenheit:");
int fahrenheit = Convert.ToInt32(Console.ReadLine());

int celsius = (fahrenheit - 32) * 5 / 9;

Console.WriteLine($"{fahrenheit}ºF es igual a {celsius}ºCelsius");
