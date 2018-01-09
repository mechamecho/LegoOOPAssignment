using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForLegoCourse
{
    public class Car
    {
        public string Color { get; set; }
        public string Manufacturer { get; set; }

        public Car()
        {
            
        }

        public Car(string color, string manufacturer) 
        {
            this.Color = color;
            this.Manufacturer = manufacturer;
        }
    }
}
