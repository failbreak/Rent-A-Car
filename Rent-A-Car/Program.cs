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
        /// <summary>
        /// Displays lists that are used for menu
        /// </summary>
        /// <param name="values"></param>
        public static void DisplayMenu(List<string> values)
        {
            int menuIncr = 0;
            values.ForEach(item => Console.WriteLine(++menuIncr + ") " + item));
        }
        public static string PhoneValidation()
        {
            int phone;
            while (!int.TryParse(Console.ReadLine(), out phone))
            {
                Console.WriteLine("Not a valid Number \n enter Phone Number:");

            }
            string phoneToString = phone.ToString();
            
            return phoneToString;
        }
        public static string BrandsSelect()
        {
            List<string> BrandsList = new()
            {
               "BMW",
               "Wolksvagen",
               "Volvo",
               "Opel",
               "Fiat"
            };
            bool exit = true;
            string brand;
            do
            {
                Console.Clear();
                DisplayMenu(BrandsList);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        brand = BrandsList[0];
                        exit = false;
                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        brand = BrandsList[1];
                        exit = false;
                        break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        brand = BrandsList[2];
                        exit = false;
                        break;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:
                        brand = BrandsList[3];
                        exit = false;
                        break;
                    case ConsoleKey.D5 or ConsoleKey.NumPad5:
                        brand = BrandsList[4];
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        exit = true;
                        brand = "BMW";
                        break;
                }
            } while (exit);
            return brand;
        }
        public static DateTime RentingPlan()
        {
            List<string> plans = new()
            {
                "30 days",
                "2 months"
            };
            DateTime RTo;
            bool exit = true;
            do
            {
                Console.Clear();
                DisplayMenu(plans);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        RTo = DateTime.Now.AddDays((double)30);
                        exit = false;
                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        RTo = DateTime.Now.AddDays((double)60);
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        RTo = DateTime.Now.AddDays((double)30);
                        break;
                }
            } while (exit);
            return RTo;
        }
        public static int kmParse()
        {
            int km;
            while (!int.TryParse(Console.ReadLine(), out km))
            {
                Console.Clear();
                Console.WriteLine("Enter KM:");
            }
            return km;
        }
        /// <summary>
        /// Menu for how many seats
        /// </summary>
        /// <returns>(int)Seats</returns>
        public static int Seats()
        {
            int seats;
            bool exit = true;
            do
            {
                Console.Clear();
                Console.WriteLine("2) Two Seats \n" +
                                   "4) four Seats \n" +
                                   "6) Six Seats");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        seats = 2;
                        exit = false;
                        break;
                    case ConsoleKey.D4 or ConsoleKey.NumPad4:
                        seats = 4;
                        exit = false;
                        break;
                    case ConsoleKey.D6 or ConsoleKey.NumPad6:
                        seats = 6;
                        exit = false;
                        break;

                    default:
                        Console.Clear();
                        seats = 0;
                        break;
                }
            } while (exit);
            return seats;
        }
        /// <summary>
        ///  Menu for Color
        /// </summary>
        /// <returns>(string)color</returns>
        public static string Colors()
        {
            string colors;
            bool exit = true;
            do
            {
                Console.Clear();
                Console.WriteLine("1) Red \n" +
                                  "2) Blue \n" +
                                  "3) Green");
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1:
                        colors = "red";
                        exit = false;
                        break;
                    case ConsoleKey.D2 or ConsoleKey.NumPad2:
                        colors = "blue";
                        exit = false;
                        break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        colors = "Green";
                        exit = false;
                        break;
                    default:
                        Console.Clear();
                        colors = "yellow";
                        break;
                }
            } while (exit);
            return colors;
        }
        public static void CarMenu(CarMM carMM)
        {
            Console.Clear();
            List<string> CarMenu = new() { "Register Car", "Edit Car", "Delete car", "Show all cars" };
            Console.WriteLine("Car Menu:");
            DisplayMenu(CarMenu);

            switch (Console.ReadKey(true).Key)
            {
                #region Register Car
                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                    string letters = "abcdefghijklmnopqrstuvwxyz";
                    string numbers = "0123456789";
                    Random random = new Random();
                    string num;
                    int seats = Seats();
                    Console.Write("\nColor: ");
                    string color = Colors();
                    Console.Write("\nBrand: ");
                    string brand = BrandsSelect();
                    Console.Write("\nKm: ");
                    int.TryParse(Console.ReadLine(), out int km);
                    bool exit = true;
                    List<string> CreateMenu = new() { "Confirm", "Edit" };
                    do
                    {
                        DisplayMenu(CreateMenu);
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
                                            seats = Seats();
                                            Console.Write("\nColor: ");
                                            color = Colors();
                                            Console.Write("\nbrandnd: ");
                                            brand = BrandsSelect();
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
                #region Edit Car
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
                #endregion

                #region Delete Car
                case ConsoleKey.D3 or ConsoleKey.NumPad3:
                    Console.WriteLine("Numberplate: ");
                    numberplate = Console.ReadLine();
                    carMM.carRepo.DeleteCar(numberplate);
                    break;
                #endregion
                case ConsoleKey.D4 or ConsoleKey.NumPad4:
                    carMM.carRepo.GetAllCars();
                    Console.ReadKey();
                    break;
                default:
                    Console.Clear();
                    break;
            }
        }
        public static void CustomerMenu(CarMM carMM, CustomerMM cusMM)
        {
            // Customer menu starts here
            List<string> CusMenu = new() { "Register new customer", "Rent Car"/*, " Edit customer", "Delete customer"*/ };
            Console.WriteLine("Customer Menu:");
            DisplayMenu(CusMenu);
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.D1 or ConsoleKey.NumPad1:
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Phone number: ");

                    string phone = PhoneValidation();
                    cusMM.customerRep.NewCustomer(name, phone);
                    break;
                case ConsoleKey.D2 or ConsoleKey.NumPad2:
                    bool exit = true;
                    do
                    {
                        Console.Write("phonenumber: ");
                        phone = Console.ReadLine();
                        if (cusMM.customerRep.PhoneValids(phone) != "not valid")
                        {
                            exit = false;
                        }
                    } while (exit);
                    Console.Clear();
                    carMM.carRepo.GetAllCars();
                    Console.Write("numberplate: ");
                    string numberplate = Console.ReadLine();
                    Console.Clear();
                    DateTime rFrom = DateTime.Now;
                    DateTime rTo = RentingPlan();
                    cusMM.customerRep.MakeReservation(phone, numberplate, rFrom, rTo);
                    break;

                case ConsoleKey.D3 or ConsoleKey.NumPad3:
                    phone = PhoneValidation();
                    cusMM.customerRep.DelReservation(phone);
                    numberplate = Console.ReadLine();
                    Console.WriteLine("KM: ");
                    int km = kmParse();
                    carMM.carRepo.ReturnedCar(numberplate, km);

                    break;

                
                    //cusMM.customerRep.EditCustomer()
                default:
                    Console.Clear();
                    break;
            }
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
                DisplayMenu(MainMenu);
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.D1 or ConsoleKey.NumPad1: // Car menu starts here
                        CarMenu(carMM);
                        break;
                        case ConsoleKey.D2 or ConsoleKey.NumPad2: // Customer menu starts here
                            CustomerMenu(carMM, cusMM);
                            break;
                    case ConsoleKey.D3 or ConsoleKey.NumPad3:
                        Environment.Exit(0);
                        break;
                        default:
                        Console.Clear();
                        break;
                        }
                }
            }
        }
    }