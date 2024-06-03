using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane(35000, 300, 2015, 5, 50);
            Car car = new Car(20000, 120, 2001);
            Ship ship = new Ship(210000, 40, 1998, 480,"34A");
            plane.Show();
            car.Show();
            ship.Show();

            Console.ReadKey();
        }
    }
}
