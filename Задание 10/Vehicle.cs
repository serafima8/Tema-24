using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    abstract class Vehicle
    {
        public double Price { get; set; }
        public double Speed { get; set; }
        public int Year { get; set; }
        public Vehicle(double price, double speed, int year)
        {
            this.Price = price;
            this.Speed = speed;
            this.Year = year;
        }
        public abstract void Show();
    }
}
