using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class ExcelentPupil : Pupil
    {
        public ExcelentPupil(string sername) : base(sername) { }
        public override void Study()
        {
            Console.WriteLine($"{Sername} учится отлично!");
        }
        public override void Read()
        {
            Console.WriteLine($"{Sername} читает очень быстро!");
        }
        public override void Write()
        {
            Console.WriteLine($"{Sername} пишет без ошибок!");
        }
        public override void Relax()
        {
            Console.WriteLine($"{Sername} отдыхает, играя в шахматы!");
        }
    }
}
