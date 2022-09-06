using Rent_A_Car.Models;

namespace Rent_A_Car.Repo
{
    public interface ICarRep
    {
        void DeleteCar(string num);
        string EditCar(string num, int seats, string brand, string color, int km);
        void GetAllCars();
        Car GetCar(string num);
        string RegisterCar(string num, int seats, string color, string brand, int km);
        Car ReturnedCar(string numberplate, int km);
    }
}
