using Rent_A_Car.Models;

namespace Rent_A_Car.Repo
{
    public class CustomerRepository : ICustomer
    {
        public Customer customer { get; set; }
        private readonly List<Customer> _customer;
        int _countIncr;

        public CustomerRepository()
        {
            _customer = new List<Customer>();
        }
        #region Customer
        public void GetCustomer()
        {
            throw new NotImplementedException();
        }
        public Customer GetCustomer(int id) => _customer.Find(customer => id == customer.CustomerId);
        public void DeleteCustomer(int id) => _customer.Remove(_customer.Find(customer => id == customer.CustomerId));
        public string NewCustomer(string name, string phone)
        {
            try
            {
                ++_countIncr;
                customer = new Customer(_countIncr, name, phone);
                _customer.Add(customer);
                return $"Customer \n" +
                    $"ID: {_countIncr}" +
                    $"Name: {name}" +
                    $"Phone: {phone}";
            }
            catch (Exception)
            {
                throw;
            }
            #endregion
        }
    }
}