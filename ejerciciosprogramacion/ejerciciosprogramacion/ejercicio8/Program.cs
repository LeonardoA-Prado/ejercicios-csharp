// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca dos número enteros");
int num = int.Parse(Console.ReadLine());
int resultado = num % 10 * 10 + num / 10;

Console.WriteLine(resultado);
