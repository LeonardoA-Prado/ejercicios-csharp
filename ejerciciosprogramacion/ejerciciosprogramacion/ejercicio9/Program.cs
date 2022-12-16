// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce tu estado civil (C, S, V o D):");
char letra = Convert.ToChar(Console.ReadLine());

switch (letra)
{
    case 'C':
        Console.WriteLine("Casado");
        break;

    case 'S':
        Console.WriteLine("Soltero");
        break;

    case 'V':
        Console.WriteLine("Viudo");
        break;

    case 'D':
        Console.WriteLine("Divorciado");
        break;

    default:
        Console.WriteLine("Estado no existe");
        break;
}