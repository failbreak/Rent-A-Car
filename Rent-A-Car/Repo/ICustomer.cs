﻿using Rent_A_Car.Models;
namespace Rent_A_Car.Repo
{
    public interface ICustomer
    {
        void DeleteCustomer(int id);
        Customer DelReservation(string phone);
        string EditCustomer(int id, string phone, string name);
        Customer GetCustomer(int id);
        Customer GetCustomerByPhone(string phone);
        string MakeReservation(string customerPhone, string carPlate, DateTime reservedFrom, DateTime reservedTo);
        string NewCustomer(string name, string phone);
        string? PhoneValids(string phone);
    }
}
