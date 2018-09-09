using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();
            Console.WriteLine("Введите количество элементов очереди");
            int k,n = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            for (int i=0; i < n;i++) //Заполняем очередь случайными числами
            {
                q.Enqueue(rand.Next(50));
            }
            Console.WriteLine("Очередь");
            foreach (int el in q)
            {
                Console.WriteLine(el);
            }
            

            Queue<int> temp = new Queue<int>(); //Создаем новую очередь
            while(q.Count>0)
            {
                k = q.Dequeue(); //Извлекаем элемент из первой очереди
                if (k % 2 == 0) //Если он кратен двум помещаем в новую
                    temp.Enqueue(k);
            }
            Console.WriteLine("Измененная очередь");
            foreach (int el in temp) //Выводим полученную очередь
            {
                Console.WriteLine(el);
            }
            
            Console.ReadKey();
        }
    }
}
