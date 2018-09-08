using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class orghim                                                                               //Класс органической химии
    {
        string Name;                                                                           //Поле имени
        double massa, M;                                                                       //Поле массы и молярной массы
        public orghim(string Name, double massa, double M)                                     //Конструктор, которому в качестве параметров передаются имя, масса и молярная масса
        {
            this.Name = Name;                                                                  //Присвоение значения полям
            this.massa = massa;
            this.M = M;
            Console.WriteLine("ОРГАНИЧЕСКАЯ ХИМИЯ");
            vivod();                                                                           //Вызов метода вывода имени, массы, молярной массы
            Console.WriteLine("Химическое количество вещества: " + him_kolich());              //Вывод химического количества
            Console.WriteLine("Число молекул: " + ch_mol());                                   //Вывод числа молекул
            Console.WriteLine();
        }
        public void vivod()                                                                    //Метод вывода имени, массы, молярной массы
        {
            Console.Write("Имя: " + Name + "\n" + "Масса: " + massa + "\n" + "Молярная масса: " + M);        //Вывода имени, массы, молярной массы, используя управляющий символ \n - перевод на новую строку
            Console.WriteLine();
        }
        public double him_kolich()                                                             //Метод вычисления химического количества вещества
        {
            return massa / M;                                                                  //Возврат значения химического количества вещества
        }
        public double ch_mol()                                                                 //Метод вычисления количества молекул вещества
        {
            return him_kolich() * 6.02 * Math.Pow(10, 23);                                     //Возврат значения количества молекул вещества
        }

    }

    class neorghim                                                                             //Класс неорганической химии
    {
        string Name;
        double massa, M;
        public neorghim(string Name, double massa, double M)
        {
            this.Name = Name;
            this.massa = massa;
            this.M = M;
            Console.WriteLine("НЕОРГАНИЧЕСКАЯ ХИМИЯ");
            vivod();
            Console.WriteLine("Химическое количество вещества: " + him_kolich());
            Console.WriteLine("Число молекул: " + ch_mol());
            Console.WriteLine();
        }
        public void vivod()
        {
            Console.Write("Имя: " + Name + "\n" + "Масса: " + massa + "\n" + "Молярная масса: " + M);
            Console.WriteLine();
        }
        public double him_kolich()
        {
            return massa / M;
        }
        public double ch_mol()
        {
            return him_kolich() * 6.02 * Math.Pow(10, 23);
        }

    }

    class polymer                                                            //Класс полимеров
    {
        string Name;
        double massa, M;
        public polymer(string Name, double massa, double M)
        {
            this.Name = Name;
            this.massa = massa;
            this.M = M;
            Console.WriteLine("ПОЛИМЕРЫ");
            vivod();
            Console.WriteLine("Химическое количество вещества: " + him_kolich());
            Console.WriteLine("Число молекул: " + ch_mol());
            Console.WriteLine();
        }
        public void vivod()
        {
            Console.Write("Имя: " + Name + "\n" + "Масса: " + massa + "\n" + "Молярная масса: " + M);
            Console.WriteLine();
        }
        public double him_kolich()
        {
            return massa / M;
        }
        public double ch_mol()
        {
            return him_kolich() * 6.02 * Math.Pow(10, 23);
        }

    }

    class nefteh                                                         //Класс нефтехимии
    {
        string Name;
        double massa, M;
        public nefteh(string Name, double massa, double M)
        {
            this.Name = Name;
            this.massa = massa;
            this.M = M;
            Console.WriteLine("НЕФТЕХИМИЯ");
            vivod();
            Console.WriteLine("Химическое количество вещества: " + him_kolich());
            Console.WriteLine("Число молекул: " + ch_mol());
            Console.WriteLine();
        }
        public void vivod()
        {
            Console.Write("Имя: " + Name + "\n" + "Масса: " + massa + "\n" + "Молярная масса: " + M);
            Console.WriteLine();
        }
        public double him_kolich()
        {
            return massa / M;
        }
        public double ch_mol()
        {
            return him_kolich() * 6.02 * Math.Pow(10, 23);
        }

    }

    class elastomer                                                         //Класс эластомеров
    {
        string Name;
        double massa, M;
        public elastomer(string Name, double massa, double M)
        {
            this.Name = Name;
            this.massa = massa;
            this.M = M;
            Console.WriteLine("Эластомеры");
            vivod();
            Console.WriteLine("Химическое количество вещества: " + him_kolich());
            Console.WriteLine("Число молекул: " + ch_mol());
            Console.WriteLine();
        }
        public void vivod()
        {
            Console.Write("Имя: " + Name + "\n" + "Масса: " + massa + "\n" + "Молярная масса: " + M);
            Console.WriteLine();
        }
        public double him_kolich()
        {
            return massa / M;
        }
        public double ch_mol()
        {
            return him_kolich() * 6.02 * Math.Pow(10, 23);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            orghim spirt = new orghim("Спирт", 1000, 1000);                          //Объявление и инициализация объекта "Спирт" класса "Органическая химия" и присвоение его полю имени, массы и молярной массы
            orghim zhir = new orghim("Жир", 100, 1000);
            orghim efir = new orghim("Эфиры", 10000, 1000);
            orghim aldegid = new orghim("Альдегиды", 500, 1000);
            orghim uglev = new orghim("Углеводороды", 500, 100);
            orghim udobren = new orghim("Удобрения", 100, 1000);
            orghim bit_him = new orghim("Бытовая химия", 500, 1000);

            neorghim metal = new neorghim("Металлы", 50, 1000);                      //Объявление и инициализация объекта "Металл" класса "Неорганическая химия" и присвоение его полю имени, массы и молярной массы
            neorghim nemetal = new neorghim("Неметаллы", 5, 1000);
            neorghim oks = new neorghim("Оксиды", 50, 1300);
            neorghim soli = new neorghim("Соли", 50, 2300);
            neorghim osnovan = new neorghim("Основания", 10, 1300);
            neorghim kisloti = new neorghim("Кислоты", 150, 1300);
            neorghim karb = new neorghim("Карбиды", 520, 1300);

            polymer sint = new polymer("Синтетические полимеры", 5320, 1300);        //Объявление и инициализация объекта "Синтетические полимеры" класса "Полимеры" и присвоение его полю имени, массы и молярной массы
            polymer iskuss = new polymer("Исскуственные полимеры", 320, 1300);
            polymer cellop = new polymer("Целлофаны", 1320, 1300);
            polymer polytilen = new polymer("Политилены", 3320, 130);
            polymer pvh = new polymer("ПВХ", 12320, 1300);
            polymer polyvin = new polymer("Поливинилхлориды", 10, 13020);
            polymer polyst = new polymer("Полистироллы", 3320, 130);

            nefteh benzol = new nefteh("Бензолы", 120, 130);                         //Объявление и инициализация объекта "Бензолы" класса "Нефтехимия" и присвоение его полю имени, массы и молярной массы
            nefteh shini = new nefteh("Шины", 1200, 130);
            nefteh kauch = new nefteh("Синтетический каучук", 1230, 1130);
            nefteh tehnugl = new nefteh("Технический углерод", 1120, 1110);
            nefteh fenol = new nefteh("Фенолы", 1000, 12430);
            nefteh ketoni = new nefteh("Кетоны", 1500, 12430);
            nefteh etilen = new nefteh("Этилены", 100, 12430);

            elastomer naturkauch = new elastomer("Натуральный каучук", 10, 12430);   //Объявление и инициализация объекта "Натуральный каучук" класса "Эластомеры" и присвоение его полю имени, массы и молярной массы
            elastomer polyiz = new elastomer("Полиизопропены", 11230, 12430);
            elastomer butadienk = new elastomer("Бутадиеновый каучук", 133330, 12430);
            elastomer hloropenk = new elastomer("Хлоропеновый каучук", 1011, 12430);
            elastomer polysk = new elastomer("Полисульфидный каучук", 1041, 12430);
            elastomer ftork = new elastomer("Фторкаучук", 1110, 12430);
            elastomer polyur = new elastomer("Полиуретаны", 23412, 12430);

            Console.ReadKey();                                                        //Ожидание нажатия клавиши
        }
    }
}
