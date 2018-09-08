using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;                                                            //Переменные x и y
            Console.WriteLine("Введите x:");                                     //Сообщение о вводе x
            x = Convert.ToInt32(Console.ReadLine());                             //Ввод значения x в переменную
            Console.WriteLine("Введите y:");                                     //Сообщение о вводе x
            y = Convert.ToInt32(Console.ReadLine());                             //Ввод значения y в переменную
            if (x + y <= 1 && 2 * x - y <= 1 && y >= 0)                          //Проверка трех условий
                Console.Write("Точка принадлежит замкнутому множеству D");       
            else Console.Write("Точка не принадлежит замкнутому множеству D");
            Console.ReadKey();                                                   //Ожидание нажатия клавиши
        }
    }
}
