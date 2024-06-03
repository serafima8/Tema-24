using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class GoodPupil : Pupil
    {
        public GoodPupil(string sername) : base(sername) { }
        public override void Study()
        {
            Console.WriteLine($"{Sername} учится хорошо!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Sername} читает достаточно быстро!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Sername} пишет с небольшими ошибками!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Sername} отдыхает, смотря телевизор!");
        }
    }
}
