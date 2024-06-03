using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class BadPupil : Pupil
    {
        public BadPupil(string sername) : base(sername) { }
        public override void Study()
        {
            Console.WriteLine($"{Sername} учится плохо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Sername} читает очень медленно!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Sername} пишет с большим количеством ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Sername} отдыхает, играя в компьютерные игры!");
        }
    }
}
