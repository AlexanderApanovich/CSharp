using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
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
            try
            {
                for (int i = 0; i < 17; i++)
                {
                    arrtheater[i] = new Theater();
                    Console.WriteLine(arrtheater[i]);
                }
            }
            catch(IndexOutOfRangeException ex) //Сначала вылавливаем более узкую ошибку(в данном случае выход за пределы массива)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            catch(Exception ex) //Вылавливаем любое исключение
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.Read();
        }
    }
}
