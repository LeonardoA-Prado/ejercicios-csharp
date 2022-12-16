// See https://aka.ms/new-console-template for more information
Console.WriteLine("Introduce la cantidad de número:");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Introduce {num} números");

double sum;
double cuad = 0;
double media;

for (int i = 0; i < num; i++)
{
    sum = Convert.ToDouble(Console.ReadLine());
    cuad += Math.Pow(sum, 2);
}

media = Math.Sqrt(cuad / num);
Console.WriteLine(media);
