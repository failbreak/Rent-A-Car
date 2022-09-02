using Rent_A_Car.Repo;

namespace Rent_A_Car.BLL
{
    public class CustomerMM
    {
        public readonly ICustomer customerRep;

        public CustomerMM(ICustomer customer)
        {
            customerRep = customer;
        }
    }
}
