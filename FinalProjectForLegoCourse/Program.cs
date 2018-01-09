using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForLegoCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            var car1=new Car("Red", "Toyota");

            var saloonCar1= new SaloonCar(2);
            var saloonCar2 = new SaloonCar(3, "Nissan");
            var saloonCar3= new SaloonCar(4, "Ford", "Purple");

        }
    }
}
