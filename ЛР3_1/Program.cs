using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3_3
{
    class Program
    {
        public static int[] vvod(int n)                                                  //Метод для чтения массива
        {
            int[] a = new int[n];                                                        //Выделение памяти для вводимого массива
            for (int i = 0; i < n; i++) a[i] = Convert.ToInt32(Console.ReadLine());      //Цикл ввода массива
            return a;                                                                    //Возврат значения метода
        }

        public static int[] massiv(int[] a)                                              //Метод для сглаживания массива
        {
            int n = a.Length, k;                                                         //Длина массива и буфферная переменная
            if (n <= 1) return a;                                                        //Если длина массива меньше 1, то ничего не делать
            k = a[1];                                                                    //Присваиваем буфферной переменной значение второго элемента массива
            for (int i = 1; i < n - 1; i++)                                              //Цикл сглаживания массива
            {
                if (i == 1)                                                              //Если элемент массива - второй (первый сглаживаемый)
                {
                    a[i] = (a[i - 1] + a[i] + a[i + 1]) / 3;
                }
                else                                                                     //Если сглаживаемый элемент имеет другой номер
                {
                    a[i] = (k + a[i] + a[i + 1]) / 3;
                    k = a[i];
                }
            }
            return a;                                                                    //Возврат значения метода
        }

        public static void vivod(int[] a)                                                //Метод для вывода массива
        {
            for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");                //Цикл для сглаживания массива
        }

        static void Main(string[] args)
        {
            int n;                                                                       //Количество элементов
            Console.Write("Введите n: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы массива: ");
            vivod(massiv(vvod(n)));                                                      //Вызов метода вывода, вызывающего метод сглаживания, который в свою очередь вызывает метод ввода
            Console.ReadKey();                                                           //Ожидание нажатия клавиши
        }
    }
}
