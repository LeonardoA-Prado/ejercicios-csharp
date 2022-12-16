namespace ejercicio20;
class Program
{
    enum Mes { Enero = 1, Febrero, Marzo, Abril, Mayo, Junio, Julio, Agosto, Septiembre, Octubre, Noviembre, Diciembre};
    static void Main()
    {
        Console.WriteLine("Introduce mes del año (1 - 12)");
        int mes = int.Parse(Console.ReadLine());

        Console.WriteLine((Mes)mes);

    }
}
