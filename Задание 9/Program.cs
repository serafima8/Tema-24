using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_9
{
    class Program
    {
        static void Main(string[] args)
        {

            Pupil pupil = new ExcelentPupil("Петров");
            ClassRoom classRoom = new ClassRoom(pupil);
            classRoom.Show(pupil);
            Pupil pupil1 = new GoodPupil("Иванов");
            ClassRoom classRoom1 = new ClassRoom(pupil,pupil1);
            classRoom1.Show(pupil1);
            Pupil pupil2 = new BadPupil("Сидоров");
            ClassRoom classRoom2 = new ClassRoom(pupil, pupil1, pupil2);
            classRoom2.Show(pupil2);

            Console.ReadKey();
        }
    }
}
