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
        public int Seats { get; set; }
        public string CarColor { get; set; }
        public string CarBrand { get; set; }
        public List<Reservation> Reservations { get; set;}
        
        public Car(string numberPlate, int seats, string carColor, string carBrand)
        {
            NumberPlate = numberPlate;
            Seats = seats;
            CarColor = carColor;
            CarBrand = carBrand;
        }

    }
}
