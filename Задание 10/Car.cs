using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Car : Vehicle
    {
        public Car(double price, double speed, int year):base(price, speed, year) { }
        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Цена автомобиля: {Price}");
            Console.WriteLine($"Скорость автомобиля: {Speed}");
            Console.WriteLine($"Год выпуска: {Year}");
        }
    }
    
}
