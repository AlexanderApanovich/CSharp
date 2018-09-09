using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab14
{
    class Program
    {
        static void Main(string[] args)
        {           
            Motorist[] motorists = new Motorist[5];
            motorists[0] = new Motorist("Kawasaki", 1990, 32, 412, "зеленый", 1337, "Пупкин", "Вася", "Иннокентьевич");
            motorists[1] = new Motorist("Subaru", 2000, 312, 41232, "красный", 1917, "Багов", "Игорь", "Викторович");
            motorists[2] = new Motorist("Kawasaki", 2001, 22, 414, "красный", 2517, "Кеков", "Владимир", "Петрович");
            motorists[3] = new Motorist("Kawasaki", 1994, 233, 424, "красный", 322, "Иванов", "Иван", "Иванович");
            motorists[4] = new Motorist("Subaru", 2007, 1332, 814, "желтый", 322, "Шатохин", "Артем", "Павлович");
            MotoristsList motorist = new MotoristsList(motorists);
            motorist.OutputInfo();
            Console.WriteLine("---");
            motorist.AgeFilter(2018);         
            motorist.ChosenMarkSameColor();
            Console.ReadKey();            
        }
    }
}
