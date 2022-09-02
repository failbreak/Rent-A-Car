using Rent_A_Car.Repo;

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
