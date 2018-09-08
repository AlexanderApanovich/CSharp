using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static int[] vvod(int n)                                                 //Метод для ввода данных массива
        {
            int[] a = new int[n];                                                       //Объявление массива
            for (int i = 0; i < n; i++) a[i] = Convert.ToInt32(Console.ReadLine());     //Цикл ввода массива
            return a;                                                                   //Возврат значения массива
        }

        static int MaxElement(int[] a, int n)                                           //Метод поиска максимального значения массива
        {
            if (n > 1)                                                                  //Выполнять пока n не станет равно 1
                return Math.Max(a[n - 1], MaxElement(a, n - 1));                        //Используя метод Math.Max, сравниваем элемент массива и предыдущий элемент, который в свою
            return a[0];                                                                //очередь сравнивается с предыдущим за ним. В итоге выполнения программы первый элемент сравнивается
        }                                                                               //со вторым и так далее. После прогона всего массива возвращается максимальный элемент
        
        static void Main(string[] args)
        {
            int[] a;                                                                    //Объявление переменной массива
            int n;                                                                      //Объявление переменной размера массива
            Console.Write("Введите количество элементов: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите элементы: ");
            a = vvod(n);                                                                //Вызов метода ввода массива
            Console.WriteLine("Максимальный элемент: "+MaxElement(a, a.Length));        //Вывод максимального элемента
            Console.ReadKey();                                                          //Ожидание нажатия клавиши
        }
    }
}
