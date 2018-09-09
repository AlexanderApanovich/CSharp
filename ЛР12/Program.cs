using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();
            Console.WriteLine("Введите количество элементов стека");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите искомый элемент");
            int elem = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Хотите заполнить стек случайными числами? (y/n)");
            ConsoleKeyInfo choice = Console.ReadKey(true); //Считываем значение нажатой клавиши
 
            switch (choice.KeyChar)
            {
                case 'y': //Если y, то заполняем случайными числами
                    Random rand = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        stack.Push(rand.Next(50));                      
                    }
                    break;
                case 'n': //Если n, заполняем вручную
                    for (int i = 0; i < n; i++)
                    {
                        Console.WriteLine("Введите следующий элемент стека");
                        stack.Push(Convert.ToInt32(Console.ReadLine()));
                    }
                    break;
                default: //Если что-либо другое, то считаем что способ заполнения не выбран и завершаем программу после нажатия любой клавиши
                    Console.WriteLine("Не выбран тип заполнения стека");
                    Console.ReadKey(true);
                    return;
              
            }
            
            int sum = 0;
            foreach(int el in stack) //Ищем количество элементов, соответствующих заданному
            {
                if (el == elem)
                    sum++;
            }
           
            Console.WriteLine("Количество элементов со значением {0} в стеке = {1}",elem,sum);
            Console.ReadKey();
        }
    }
}
