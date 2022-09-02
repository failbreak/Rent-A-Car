
using Microsoft.Extensions.DependencyInjection;
using Rent_A_Car.BLL;
using Rent_A_Car.Repo;

namespace Rent_A_Car
{
    public class Program
    {
        public static void Main()
        {
            ServiceProvider Sp = new ServiceCollection()
                .AddSingleton<ICarRep, CarRepository>()
                .AddSingleton<ICustomer, CustomerRepository>()
                .BuildServiceProvider();
            CarMM carMM = new(Sp.GetService<ICarRep>());
            CustomerMM cusMM = new(Sp.GetService<ICustomer>());

            Menu(carMM, cusMM);
        }

        public static void Menu(CarMM carMM, CustomerMM cusMM)
        {
            List<string> MainMenu = new()
            {
                "Car Menu",
                "Customer menu"
            };

            while (true)
            {
                Console.Clear();
                int menuIncr = 0;
                MainMenu.ForEach(item => Console.WriteLine(++menuIncr + ") " + item));
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        List<string> CarMenu = new() { "Register Car", "Edit Car", "Delete car" };
                        Console.WriteLine("Car Menu:");

                        switch (Console.ReadKey(true).Key)
                        {


                            #region Register Car
                            case ConsoleKey.D1 or ConsoleKey.NumPad1:
                                List<string> CreateMenu = new() { "Confirm", "Edit" };
                                string letters = "abcdefghijklmnopqrstuvwxyz";
                                string numbers = "0123456789";
                                Random random = new Random();
                                string num;
                                Console.Write("Number of seats: ");
                                int.TryParse(Console.ReadLine(), out int seats);
                                Console.Write("\nColor: ");
                                string color = Console.ReadLine();
                                Console.Write("\nBrand: ");
                                string brand = Console.ReadLine();
                                Console.Write("\nKm: ");
                                int.TryParse(Console.ReadLine(), out int km);
                                bool exit = true;
                                do
                                {
                                    menuIncr = 0;
                                    CreateMenu.ForEach(item => Console.WriteLine(++menuIncr + ") " + item));
                                    #region PlateGen
                                    num = string.Empty;
                                    for (int i = 0; i < 2; i++)
                                    {
                                        num += letters[random.Next(0, letters.Length)];
                                    }
                                    num += " ";
                                    for (int i = 0; i < 2; i++)
                                    {
                                        num += numbers[random.Next(0, numbers.Length)];
                                    }
                                    num += " ";
                                    for (int i = 0; i < 3; i++)
                                    {
                                        num += numbers[random.Next(0, numbers.Length)];
                                    }
                                    #endregion
                                    switch (Console.ReadKey(true).Key)
                                    {
                                        case ConsoleKey.D1 or ConsoleKey.NumPad1:
                                            carMM.carRepo.RegisterCar(num, seats, color, brand, km);
                                            exit = false;
                                            break;

                                        case ConsoleKey.D2 or ConsoleKey.NumPad2:
                                            do
                                            {
                                                Console.Clear();
                                                Console.WriteLine($"Car Data: \n" +
                                                    $"seats: {seats}\n" +
                                                    $"Color: {color} \n" +
                                                    $"brand: {brand}");
                                                Console.WriteLine("Is this Correct? \n Y/N");
                                                switch (Console.ReadKey(true).Key)
                                                {
                                                    case ConsoleKey.Y:
                                                        carMM.carRepo.RegisterCar(num, seats, color, brand, km);
                                                        exit = false;
                                                        break;

                                                    case ConsoleKey.N:
                                                        Console.Clear();
                                                        Console.Write("Number of seats: ");
                                                        int.TryParse(Console.ReadLine(), out int seatsEdit);
                                                        seats = seatsEdit;
                                                        Console.Write("\nColor: ");
                                                        color = Console.ReadLine();
                                                        Console.Write("\nbrandnd: ");
                                                        brand = Console.ReadLine();
                                                        Console.Write("\nKm: ");
                                                        int.TryParse(Console.ReadLine(), out int kmEdit);
                                                        km = kmEdit;
                                                        break;
                                                    default:
                                                        Console.Clear();
                                                        break;
                                                }
                                            } while (exit);
                                            break;

                                        default:
                                            Console.Clear();
                                            break;
                                    }
                                } while (exit);
                                break;
                            #endregion

                            case ConsoleKey.D2 or ConsoleKey.NumPad2:
                                Console.WriteLine("Numberplate: ");
                                string numberplate = Console.ReadLine();
                                Console.Write("Number of seats: ");
                                int.TryParse(Console.ReadLine(), out int seatsEdited);
                                Console.Write("\nColor: ");
                                color = Console.ReadLine();
                                Console.Write("\nBrand: ");
                                brand = Console.ReadLine();
                                Console.Write("\nKm: ");
                                int.TryParse(Console.ReadLine(), out int kmEdited);
                                km = kmEdited;
                                seats = seatsEdited;
                                carMM.carRepo.EditCar(numberplate, seats, brand, color, km);
                                break;

                            case ConsoleKey.D3 or ConsoleKey.NumPad3:
                                Console.WriteLine("Numberplate: ");
                                numberplate = Console.ReadLine();
                                carMM.carRepo.DeleteCar(numberplate);
                                break;
                            default:
                                Console.Clear();
                                break;
                        }
                        break;

                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        List<string>
                        switch ()
                        {
                            default:
                                break;
                        }
                        break;

                    case ConsoleKey.D3 or ConsoleKey.NumPad3:

                        break;
                    default:
                        Console.Clear();
                        break;
                }
            }
        }
    }
}