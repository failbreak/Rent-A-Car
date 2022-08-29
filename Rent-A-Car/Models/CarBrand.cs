using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent_A_Car.Models
{
    public class CarBrand
    {
        public string Carbrand { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }

        public CarBrand(string _Carbrand, string _CarModel, string _CarColor)
        {
            Carbrand = _Carbrand;
            CarModel = _CarModel;
            CarColor = _CarColor;
        }
    }
}
