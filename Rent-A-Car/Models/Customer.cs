using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public Customer(int _CustomerId, string _CustomerName, string _CustomerPhone)
        {
            CustomerId = _CustomerId;
            CustomerName = _CustomerName;
            CustomerPhone = _CustomerPhone;
        }
    }
}
