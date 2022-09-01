using Rent_A_Car.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Models
{
    public class Car
    {
        public string NumberPlate { get; set; }
        public int CarSeats { get; set; }
        public string CarColor { get; set; }
        public string CarBrand { get; set; }
        public int CarKm { get; set; }
        public List<Reservation> Reservations { get; set;}
        
        public Car(string numberPlate, int seats, string carColor, string carbrand, int carKm)
        {
            NumberPlate = numberPlate;
            CarSeats = seats;
            CarColor = carColor;
            CarBrand = carbrand;
            CarKm = carKm;
        }

    }
}
