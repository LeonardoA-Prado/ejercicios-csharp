namespace ejercicio21
{
    internal class Program
    {
        enum DayOfWeek { Lunes = 1, Martes = 2, Miercoles = 3, Jueves = 4, Viernes = 5, Sabado = 6, Domingo = 7 };
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un dia de la semana;");


            DayOfWeek day = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine(), true);

            int num = (int)day;

            if (num <= 5)
            {
                Console.WriteLine($"{(DayOfWeek)num} es laboral");
            }
            else
            {
                Console.WriteLine($"{(DayOfWeek)num} no es laboral");
            }
            Console.ReadLine();
        }
    }
}