using Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Repo
{
    public interface ICustomer
    {
        void DeleteCustomer(int id);
        Customer GetCustomer(int id);
        string NewCustomer(string name, string phone);
    }
}
