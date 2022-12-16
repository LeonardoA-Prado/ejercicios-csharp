namespace ejercicio22
{
    internal class Program
    {
        enum State { On, Off };
        static void Main(string[] args)
        {
            State state = State.Off;

            while (true)
            {
                Console.WriteLine($"El estado actual es :{state}");
                Console.WriteLine("Introduce accion");
                string input = Console.ReadLine();
                State action = (State)Enum.Parse(typeof(State), input, true);

                if (state == State.On && action == State.Off)
                {

                    state = State.Off;
                }
                else if (state == State.Off && action == State.On)
                {

                    state = State.On;
                }
                else
                {
                    throw new Exception("Accion no valida");
                }
            }
        }
    }
}