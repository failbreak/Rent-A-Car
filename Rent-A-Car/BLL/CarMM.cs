using Rent_A_Car.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.BLL
{
    public class CarMM
    {
        public readonly ICarRep carRepo;

        public CarMM(ICarRep carRep)
        {
            carRepo = carRep;
        }
    }
}
