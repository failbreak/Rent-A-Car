
namespace Rent_A_Car.Models
{
    public class Reservation
    {
        public DateTime ReservedFrom { get; set; }
        public DateTime ReservedTo { get; set; }
        public string number { get; set; }
        public string phone { get; set; }
        public Reservation(string customerPhone, string carPlate, DateTime reservedFrom, DateTime reservedTo)
        {
            phone = customerPhone;
            number = carPlate;
            ReservedFrom = reservedFrom;
            ReservedTo = reservedTo;
        }
    }
}
