using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР1_2
{
    class Program
    {
        public static double Expon1(double t)        //Метод для вычисления числа пи через цикл while
        {
            double res = 0f;                         //Переменная для хранения результата
            Int64 a = 1, b = 3;                      //Переменные для множителей в знаменателе
            while (t <= (Math.PI - res))
            {                                        //Цикл для высчитывания: пока точность меньше разности необходимого значения и подсчитанного значения, выполнять цикл
                res = res + 8.0 / (a * b);           //Прибавляем к результату очередной член ряда
                a = a + 4;                           //Увеличиваем оба множителя знаменателя члена ряда
                b = b + 4;
            }
            return res;                              //Возвращаем результат вычислений
        }
        public static double Expon2(double t)        //Аналогично первому методу, только через цикл do while
        {
            double res = 0f;
            Int64 a = 1, b = 3;
            do
            {
                res = res + 8.0 / (a * b);
                a = a + 4;
                b = b + 4;
            }
            while (t <= (Math.PI - res));
            return res;                              //Возвращаем результат вычислений
        }
        static void Main(string[] args)
        {
            int t1;                                                                     //Переменная для хранения количества знаков
            double t;                                                                   //Переменная для хранения точности вычислений
            Console.WriteLine("Введите количество знаков: ");                           //Вывод сообщения с просьбой ввести количество знаков в числе пи
            t1 = Convert.ToInt32(Console.ReadLine());                                   //Ввод значения в переменную t1
            t = Math.Pow(10, -t1);                                                      //Вычисление переменной t
            Console.WriteLine("Ответ, полученный через цикл while: " + Expon1(t));      //Вывод значения числа пи с заданной точностью, подсчитанной через цикл while
            Console.WriteLine("Ответ, полученный через цикл do while: " + Expon2(t));   //Вывод значения числа пи с заданной точностью, подсчитанной через цикл do while
            Console.ReadKey();                                                          //Ожидание нажатия клавиши
        }
    }
}
