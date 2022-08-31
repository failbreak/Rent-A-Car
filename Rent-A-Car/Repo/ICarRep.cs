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
        string EditCar(string num, int sea, string bra, string col);
        Car GetCar(string num);
        string NewCar(string num, int sea, string col, string bra);
    }
}
