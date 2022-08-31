namespace Rent_A_Car
{
    public class Program
    {
        public static void Main()
        {
            Menu();
        }

        public static void Menu()
        {
            while (true)
            {


                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:

                        break;

                    case ConsoleKey.D2 or ConsoleKey.NumPad2:

                        break;

                    case ConsoleKey.D3 or ConsoleKey.NumPad3:

                        break;

                    case ConsoleKey.D4 or ConsoleKey.NumPad4:

                        break;


                    default:
                        Console.Clear();
                        break;
                }
            }
        }

    }
}