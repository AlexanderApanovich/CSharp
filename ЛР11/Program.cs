using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab11 //Вычислите А1 – А2 + А3 – ... + (–1)N-1АN.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Введите размер массива");
            n = Convert.ToInt32(Console.ReadLine());
            List<double> list = new List<double>(1); //Создаем новый список
            for(int i=0;i<n;i++)
            {
                Console.Write("Введите {0} элемент списка ", i);
                list.Add(Convert.ToDouble(Console.ReadLine())); //Добавляем элементы
            }
            Console.WriteLine("Cписок");
            foreach (double p in list) //Выводим все элементы
            {
                Console.WriteLine(p);
            }
            double sum = 0,sign=1;
            for (int i = 0; i < n; i++) //Считаем сумму по заданию
            {               
                sum += sign * list[i];
                sign *= -1;
            }

            list.Add(sum); //Добавляем в конец списка сумму
            Console.WriteLine("Искомая сумма");
            Console.WriteLine(list[n]); //Выводим элемент,в котором хранится сумма
                       
            Console.ReadKey();
        }
    }
}
