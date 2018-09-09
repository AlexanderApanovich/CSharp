using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР6_1
{
    class cvetok
    {
        public int n;                            //Количество лепестков
        public string color;                     //Цвет бутона
        protected bool cvetenie = false;         //Поле типа boolean: если цветок цветет - true, иначе - false 
        protected bool zavyal = false;           //Поле типа boolean: если цветок завял - true, иначе - false

        public bool Cvetenie                //Свойство
        {
            get
            {
                return cvetenie;         //При чтении cvetok.Cvetenie - возвращать значение cvetenie
            }
            set
            {
                cvetenie = value;        //При записи cvetok.Cvetenie - присваивать полю cvetenie присваеваемое cvetok.Cvetenie значение 
            }
        }

        public bool Zavyal                //Свойство
        {
            get
            {
                return zavyal;         //При чтении cvetok.Zavyal - возвращать значение zavyal
            }
            set
            {
                zavyal = value;        //При записи cvetok.Zavyal - присваивать полю zavyal присваеваемое cvetok.Zavyal значение 
            }
        }

        public cvetok()                                          //Конструктор класса цветок
        {
            if (cvetenie) Console.WriteLine("Цветок цветет");    //Если если цветок цветет или завял - вывести сообщение
            if (zavyal) Console.WriteLine("Цветок завял");
            Console.WriteLine("-----------------");
        }

        public void vivod()                                    //Метод вывода цвета бутона
        {
            Console.WriteLine("Цвет бутона - "+color);         
        }

        public virtual void condition()               //Родительский метод
        {
            zavyal = false;                         //Поле типа boolean: если цветок завял - true, иначе - false
            cvetenie = false;                       //Поле типа boolean: если цветок цветет - true, иначе - false
            Console.WriteLine("Цветок в обычном состоянии, количество лепестков сейчас: " + n);   //Вывод сообщения о состоянии цветка
        }

    }

    class lepestok : cvetok           //Класс лепестка, унаследованный от класса цветок
    {
        public int N                //Свойство
        {
            get
            {
                return n;         //При чтении lep.N - возвращать значение n
            }
            set
            {
                n = value;        //При записи lep.N - присваивать полю n присваеваемое lep.N значение 
            }
        }
        
        public lepestok() : base()               //Наследованный конструктор
        {
            Console.WriteLine("Объект класса лепесток создан! ("+ToString()+")");      //Вывод сообшения о создании объекта класса лепесток
        }                                                                              //а также использование метода toString() для получения строки, представляющей этот объект

        public override void condition()                                            //Перезаписанный родительский метод для случая, когда цветок завял
        {
            int n1 = n - 5;            //Количество лепестков после этого
            zavyal = true;             
            cvetenie = false;
            Console.WriteLine("Цветок завял, количество лепестков сейчас: "+n1);      //Вывод сообщения о том, что цветок завял количества лепестков
        }
    }

    class buton : cvetok        //Класс бутона, унаследованный от класса цветок
    {
        public string Color       //Свойство
        {
            get
            {
                return color;     //При чтении but.Color - возвращать значение color
            }
            set
            {
                color = value;    //При записи but.Color - присваивать полю color присваеваемое lep.Color значение 
            }
        }
        public buton() : base ()   //Наследованный конструктор
        {
            Console.WriteLine("Объект класса бутон создан! (" + ToString() + ")");  //Вывод сообшения о создании объекта класса лепесток
        }                                                                           //а также использование метода toString() для получения строки, представляющей этот объект

        public override void condition()       //Перезаписанный родительский метод для случая, когда цветок завял
        {
            int n1 = n + 5;        //Количество лепестков после этого
            cvetenie = true;
            zavyal = false;
            Console.WriteLine("Цветок цветет, количество лепестков сейчас: "+n1);     //Вывод сообщения о том, что цветок завял количества лепестков
        }

    }
    
    class Program
    {
        static void Main(string[] args)
        {
            cvetok cv = new cvetok();             //Создание объектов классов цветок, лепесток, бутон
            lepestok lep = new lepestok();
            buton but = new buton();

            Console.WriteLine("Введите количество лепестков:");      
            lep.N = Convert.ToInt32(Console.ReadLine());                     //Использование свойства N класса лепесток для ввода информации в поле объекта lep
            Console.WriteLine("Введите цвет бутона:");
            but.Color = Console.ReadLine();                                  //Использование свойства Color класса бутон для ввода информации в поле объекта but

            cv.color = but.Color;           //Использование свойства Color класса бутон для ввода информации в поле color объекта cv
            cv.n = lep.N;                   //Использование свойства N класса лепесток для ввода информации в поле n объекта cv
            but.n = lep.N;                  //Использование свойства N класса лепесток для ввода информации в поле n объекта but

            cv.condition();                 //Вызов методов вывода информации о нормальном состоянии цветка,
            but.condition();                //Метод цветения
            lep.condition();                //Метод завядания
            cv.vivod();                     //Метод вывода цвета бутона

            Console.ReadKey();              //Ожидание нажатия клавиши
        }
    }
}
