using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР5_2
{
    class trapec
    {
        double a, b, c, d;                                          //Поля сторон трапеции
        public trapec(double a, double b, double c, double d)       //Конструктор класса
        {
            this.a = a;         //Присвоение значений аргументов полям
            this.b = b;
            this.c = c;
            this.d = d;
        }

        public void uvelich(double n)          //Метод увеличения сторон в n раз
        {
            a *= n;         
            b *= n;
            c *= n;
            d *= n;
            Console.WriteLine(a+" "+b+ " " + c+ " " + d);
        }

        public double perimetr()          //Метод, возвращающий периметр
        {
            return a + b + c + d;
        }

        public double ploschad()          //Метод, возвращающий площадь
        {
            return ((a + b) / 2) * Math.Sqrt(c * c - (Math.Pow(((b - a) * (b - a) + c * c - d * d) / (2 * (b - a)), 2)));
        }

        public bool check()               //Метод, возвращающий true, если трапеция существует, иначе - false
        {
            if (a<b+c+d && b<c+a+d && c<a+b+d && d<a+b+c) return true;
            else return false;
        }

        public bool podobie(trapec[] array,int i)         //Метод, возвращающий true, если трапеции подобны, иначе - false
        {
            bool storoni = false, ugli = false;           //Поля типа boolean - если стороны подобны и углы, то true, иначе - false
            double a1 = array[i].a;            //Размеры трапеции, взятые из массива
            double b1 = array[i].b;
            double c1 = array[i].c;
            double d1 = array[i].d;
            double h;                    //Высота
            h = Math.Sqrt(c * c - Math.Pow(((Math.Pow(b - a, 2) + c * c - d * d) / (2 * (b - a))), 2));
            double h1 = Math.Sqrt(c1 * c1 - Math.Pow(((Math.Pow(b1 - a1, 2) + c1 * c1 - d1 * d1) / (2 * (b1 - a1))), 2));      //Высота сравниваемой трапеции
            if ((a1 / a == b1 / b) && (a1 / a == c1 / c) && (a1 / a == d1 / d)) storoni = true;
            double alpha,alpha1,beta,beta1;           //Углы при основаниях сравниваемых трапеций
            alpha = Math.Asin(h / c);                  
            alpha1 = Math.Asin(h1 / c1);
            beta = Math.Asin(h / d);
            beta1 = Math.Asin(h1 / d);
            if ((alpha == alpha1) && (beta == beta1)) ugli=true;      
            if (storoni && ugli) return true;                       //Если стороны подобны и углы равны - вернуть true, иначе - false
            else return false;
        }

        public double srl()              //Метод, возвращающий среднюю линию
        {
            return (a + b) / 2;
        }

        public double height()           //Метод, возвращающий высоту
        {
            return Math.Sqrt(c * c - Math.Pow(((Math.Pow(b - a, 2) + c * c - d * d) / (2 * (b - a))), 2));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i;                      //Индекс сравниваемой трапеции
            double a, b, c, d, n;       
            trapec[] array = new trapec[5];        //Создание объекта класса trapec
            Console.WriteLine("Введите длину меньшего основания трапеции: ");   
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длину большего основания трапеции: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите длины боковых сторон трапеции: ");
            c = Convert.ToInt32(Console.ReadLine());
            d = Convert.ToInt32(Console.ReadLine());

            trapec abcd = new trapec(a, b, c, d);
            trapec abcd1 = new trapec(2, 4, 8, 12);
            trapec abcd2 = new trapec(5, 10, 15, 20);
            trapec abcd3 = new trapec(1, 2, 4, 4);
            trapec abcd4 = new trapec(3, 5, 15, 20);
            array[0] = abcd;                           //Занесение объектов в один массив
            array[1] = abcd1;
            array[2] = abcd2;
            array[3] = abcd3;
            array[4] = abcd4;

            if (abcd.check())         //Если трапеция существует, продолжить выполнение программы, иначе - завершить
            {
                Console.WriteLine("Трапеция существует");
                Console.WriteLine("Во сколько раз увеличить размеры? ");
                n = Convert.ToInt32(Console.ReadLine());
                abcd.uvelich(n);                            //Вызов метода увеличения размеров сторон трапеции
                Console.WriteLine("Периметр: "+abcd.perimetr());      //Вызов метода нахождения периметра
                Console.WriteLine("Площадь: "+abcd.ploschad());       //Вызов метода нахождения площади
                Console.WriteLine("Индекс сравниваемой трапеции:");
                i = Convert.ToInt32(Console.ReadLine());
                if (array[i].podobie(array, i)) Console.WriteLine("Трапеции подобны"); else Console.WriteLine("Трапеции не подобны");   //Вызов метода проверки подобия
                Console.WriteLine("Средняя линия равна "+abcd.srl());      //Вызов метода нахождения средней линии
                Console.WriteLine("Высота равна " + abcd.height());        //Вызов метода нахождения высоты
            }
            else Console.WriteLine("Трапеция не существует");
            Console.ReadKey();                                     //Ожидание нажатия клавиши
        }
    }
}
