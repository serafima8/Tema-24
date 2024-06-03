using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class ClassRoom
    {
        public ClassRoom() { }
        public ClassRoom(Pupil exelent) { }
        public ClassRoom(Pupil exelent, Pupil bad) { }
        public ClassRoom(Pupil exelent, Pupil good, Pupil bad) { }
        public ClassRoom(Pupil bad, Pupil good,Pupil exelen, Pupil good1) { }
        public void Show(Pupil pupil)
        {
            Console.WriteLine();
            Console.WriteLine($"Ученик {pupil.Sername} ");
            pupil.Study();
            pupil.Read();
            pupil.Write();
            pupil.Relax();
        }

    }
}
