using Rent_A_Car.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Models
{
    public class Car : ICar
    {
        public int CarId { get; set; }
        public string NumberPlate { get; set; }
        public int Seats { get; set; }
        public string CarColor { get; set; }
        public CarBrand CarBrand { get; set; }
        private List<Reservation> Reservations { get; set;}
        
        public Car(int _CarId, string _NumberPlate, int _Seats, string _CarColor, CarBrand _CarBrand)
        {
            CarId = _CarId;
            NumberPlate = _NumberPlate;
            Seats = _Seats;
            CarColor = _CarColor;
            CarBrand = _CarBrand;
        }

    }
}
