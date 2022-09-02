using Rent_A_Car.Models;

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
        public string RegisterCar(string num, int seats, string color, string brandnd, int km)
        {
            try
            {
                car = new Car(num, seats, color, brandnd, km);
                _Cars.Add(car);
                return $"Car created with: \n" +
                    $"NumberPlate: {num}\n" +
                    $"seats: {seats}\n" +
                    $"Color: {color}\n" +
                    $"brandnd: {brandnd} \n" +
                    $"Km: {km}";
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void DeleteCar(string num) => _Cars.Remove(_Cars.Find(car => num == car.NumberPlate));
        public string EditCar(string num, int seats, string brandnd, string color, int km)
        {
            Car caren = GetCar(num);
            caren.CarSeats = seats;
            caren.CarBrand = brandnd;
            caren.CarColor = color;
            return $"Car edit with: \n" +
                    $"NumberPlate: {num}\n" +
                    $"Seats: {seats}\n" +
                    $"Color: {color}\n" +
                    $"Brand: {brandnd}" +
                    $"Km: {km}";
        }
        #endregion
    }
}
