using Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Repo
{
    public interface ICarRep
    {
        void DeleteCar(string num);
        string EditCar(string num, int seats, string brandnd, string color, int km);
        Car GetCar(string num);
        string RegisterCar(string num, int seats, string color, string brandnd, int km);
    }
}
