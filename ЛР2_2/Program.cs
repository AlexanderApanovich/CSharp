using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР2_2
{
    class Program
    {
        public static bool del(int p)                                       //Метод, возвращающий значение true или false                                        
        {
            int sum1 = 0, sum2 = 0;                                         //Сумма нечетных и четных позиций
            for (int i = 1; p > 0; i++)                                     //Пока число вводимое число P не станет равно нулю
            {
                int tmp = p % 10;                                           //Последняя цифра числа
                if (i % 2 == 0) sum2 += tmp; else sum1 += tmp;              //Если позиция нечетная, то прибавляем в переменную sum1, иначе - в sum2
                p /= 10;                                                    //Отбрасываем последнюю цифру P
            };
            if ((sum2 - sum1) % 11 == 0) return true; else return false;    //Если знакопеременная сумма четных и нечетных позиций делится на 11 без остатка, то и само число делится на 11 без остатка
        }

        public static void deln(int p)
        {                                                                   //Аналогично предыдущему методу, но метод не возвращает никакого значения, а выводит сообщение напрямую на экран
            int sum1 = 0, sum2 = 0;
            for (int i = 1; p > 0; i++)
            {
                int tmp = p % 10;
                if (i % 2 == 0) sum2 += tmp;
                else sum1 += tmp;
                p /= 10;
            };
            if ((sum2 - sum1) % 11 == 0) Console.WriteLine("Делится на 11 без остатка (метод не возвр. зн.)");           //Вывод сообщения
            else Console.WriteLine("Не делится на 11 без остатка (метод не возвр. зн.)");
        }

        static void Main(string[] args)
        {
            int p;                                                                            //Вводимое число
            Console.WriteLine("Введите число P:");                                            //Просьба ввода
            p = Convert.ToInt32(Console.ReadLine());                                          //Чтение и запись значения в переменную p
            if (del(p)) Console.WriteLine("Делится на 11 без остатка (метод возвр. зн.)");    //Условие: если метод del вернул true, то вывести сообщение о том, что число делится без остатка на 11
            else Console.WriteLine("Не делится на 11 без остатка (метод возвр. зн.)");        //Иначе о том, что число не делится без остатка на 11
            deln(p);                                                                          //Вызов второго метода
            Console.ReadKey();                                                                //Ожидание нажатия клавиши
        }
    }
}
