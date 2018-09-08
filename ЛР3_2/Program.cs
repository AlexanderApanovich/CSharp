using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР3_2
{
    class Program
    {
        public static int[,] vvod(int n, int m)
        {                                                              //Метод для ввода данных в двумерный массив
            int[,] a = new int[n, m];                                  //Объявление двумерного массива          
            for (int i = 0; i < n; i++)                                //Цикл ввода данных в массив
                for (int j = 0; j < m; j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            return a;                                                  //Возврат значения массива
        }
        public static void vivod(int[,] a, int n, int m)
        {                                                              //Метод для вывода данных массива
            for (int i = 0; i < n; i++)
            {                                                          //Цикл для вывода данных массива на экран
                for (int j = 0; j < m; j++)
                    Console.Write("\t" + a[i, j]);                     //Вывод производится с помощью символа табуляции (\t)
                Console.WriteLine();
            }
        }
        public static int[,] transp(int[,] a, int n, int m)
        {                                                              //Метод для транспонирования
            int[,] b = new int[m, n];                                  //Объявление двумерного массива
            for (int i = 0; i < n; i++)                                //Цикл для транспонирования матрицы
                for (int j = 0; j < m; j++)
                    b[j, i] = a[i, j];                                 //Суть транспонирования сводится к тому, чтобы поменять индексы местами
            return b;                                                  //Возврат массива транспонированной матрицы
        }
        static void Main(string[] args)
        {
            int[,] a, b;                                               //Объявление двух двумерных массивов
            int n, m;                                                  //Объявление переменных размера массива
            Console.WriteLine("Введите количество строк:");
            n = Convert.ToInt32(Console.ReadLine());                   //Ввод значения переменной n
            Console.WriteLine("Введите количество столбцов:");
            m = Convert.ToInt32(Console.ReadLine());                   //Ввод значения переменной m
            Console.WriteLine("Введите элементы матрицы:");
            a = vvod(n, m);                                            //Вызов метода ввода данных в исходный массив
            b = transp(a, n, m);                                       //Присвоение значения массиву b
            Console.WriteLine("Матрица:");
            vivod(a, n, m);                                            //Вывод исходной матрицы
            Console.WriteLine("Транспонированная матрица: ");
            vivod(b, m, n);                                            //Вывод транспонированной матрицы 
            Console.ReadKey();                                         //Ожидание нажатия клавиши

        }
    }
}
