using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    abstract class Pupil
    {
        public string Sername { get; set; }
        public Pupil(string sername)
        {
            this.Sername = sername;
        }
        public abstract void Study();
        public abstract void Read();
        public abstract void Write();
        public abstract void Relax();

    }
}
