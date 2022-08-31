using Rent_A_Car.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rent_A_Car.Repo
{
    public class CarRepository : ICarRep
    {
        public Car car { get; set; }
        private List<Car> _Cars;
        public CarRepository()
        {
            _Cars = new List<Car>();
        }
        #region CarMethods
        public void GetCar()
        {
            throw new NotImplementedException();
        }
        public Car GetCar(string num) => _Cars.Find(car => num == car.NumberPlate);
        public string NewCar(string num, int sea,  string col, string bra)
        {
            try
            {
                
                car = new Car(num, sea, col, bra);
                _Cars.Add(car);
                return $"Car created with: \n" +
                    $"NumberPlate: {num}\n" +
                    $"Seats: {sea}\n" +
                    $"Color: {col}\n" +
                    $"Brand: {bra}";
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteCar(string num) => _Cars.Remove(_Cars.Find(car => num == car.NumberPlate));

        public string EditCar(string num, int sea, string bra, string col)
        {
            Car caren = GetCar(num);
            caren.Seats = sea;
            caren.CarBrand = bra;
            caren.CarColor = col;
            return $"Car edit with: \n" +
                    $"NumberPlate: {num}\n" +
                    $"Seats: {sea}\n" +
                    $"Color: {col}\n" +
                    $"Brand: {bra}";
        }
        #endregion
    }
}
