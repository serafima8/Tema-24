using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Plane : Vehicle
    {
        public double H { get; set; }
        public int Kolvo { get; set; }
        public Plane(double price, double speed, int year, double h, int kolvo):base(price, speed, year)
        {
            this.H = h;
            this.Kolvo = kolvo;
        }
        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Цена самолета: {Price}");
            Console.WriteLine($"Скорость самолета: {Speed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Высота: {H}");
            Console.WriteLine($"Количество пассажиров: {Kolvo}");
        }
    }
}
