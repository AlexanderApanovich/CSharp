﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Theater th1 = new Theater("Театр", 12551, 4, "Сцена");
            Console.WriteLine(th1);

            th1.CloseTheDoor();
            th1.OpenTheDoor();
            Theater[] arrtheater = new Theater[5];
            
            Console.ReadKey();
        }
    }
}
