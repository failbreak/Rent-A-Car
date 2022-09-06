using Rent_A_Car.Models;

namespace Rent_A_Car.Repo
{
    public class CustomerRepository : ICustomer
    {
        public Customer customer { get; set; }
        public Reservation reservation { get; set; }
        private readonly List<Customer> _customer;
        int _countIncr;
       private List<Reservation> _reservation { get; set; }

        public CustomerRepository()
        {
            _customer = new List<Customer>();
            _reservation = new List<Reservation>();
        }
        #region Customer
        public void GetCustomer()
        {
            throw new NotImplementedException();
        }
        public Customer GetCustomer(int id) => _customer.Find(customer => id == customer.CustomerId);
        public Customer GetCustomerByPhone(string phone) => _customer.Find(customer => phone == customer.CustomerPhone);
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

        public Customer DelReservation(string phone)
        {
            _reservation.Remove(_reservation.Find(reservation => reservation.phone == phone));
            return customer;
        }

        public string MakeReservation(string customerPhone, string carPlate, DateTime reservedFrom, DateTime reservedTo)
        {
            reservation = new Reservation(customerPhone, carPlate, reservedFrom, reservedTo);
            _reservation.Add(reservation);
            return $"Created Customer";
        }
        public string? PhoneValids(string phone)
        {
            Customer? customer = _customer.Find(customer => phone == customer.CustomerPhone);
            return customer != null ? "Valid Phone" : "not valid";
        }
    }
}