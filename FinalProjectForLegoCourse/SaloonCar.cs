using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForLegoCourse
{
    public class SaloonCar : Car
    {
        public byte NumberOfSeats { get; set; }

        public SaloonCar(byte numberOfSeats)
        {
            this.NumberOfSeats = numberOfSeats;
        }

        public SaloonCar(byte numberOfSeats, string manufacturer) : this(numberOfSeats)
        {
            this.Manufacturer = manufacturer;
        }

        public SaloonCar(byte numberOfSeats,  string manufacturer, string color)
            : base(manufacturer, color)
        {
            this.NumberOfSeats = numberOfSeats;
        }
    }
}
