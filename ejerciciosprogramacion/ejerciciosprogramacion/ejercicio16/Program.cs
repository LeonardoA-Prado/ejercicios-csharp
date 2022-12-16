// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduzca un numero de base 10 para convertir:");
int base10 = int.Parse(Console.ReadLine());

Console.WriteLine("Introduzca el numero de una base");
int basex = int.Parse(Console.ReadLine());

string resultado1 = "";
string resultado2 = "";
bool exit = true;

if (basex > 1 && basex < 10)

    for (int i = base10; base10 > 0 && exit; i--)
    {


        int resto = base10 % basex;
        base10 /= basex;
        resultado1 += Convert.ToString(resto);


    }
    else
    {
    Console.WriteLine("Escriba un numero entre 2 y 9");
    exit = false;
    }

for (int i = resultado1.Length - 1; i >= 0; i--)
{
    resultado2 += resultado1[i];
}
Console.WriteLine(resultado2);
