using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_10
{
    class Ship : Vehicle
    {
        public int Kolvo { get; set; }
        public string Port { get; set; }
        public Ship(double price, double speed, int year,int kolvo, string port):base(price, speed, year)
        {
            this.Kolvo = kolvo;
            this.Port = port;
        }
        public override void Show()
        {
            Console.WriteLine();
            Console.WriteLine($"Цена корабля: {Price}");
            Console.WriteLine($"Скорость корабля: {Speed}");
            Console.WriteLine($"Год выпуска: {Year}");
            Console.WriteLine($"Количество пассажиров: {Kolvo}");
            Console.WriteLine($"Порт приписки: {Port}");
        }
    }
}
