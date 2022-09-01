using Microsoft.Extensions.DependencyInjection;
using Rent_A_Car.Repo;
using Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
