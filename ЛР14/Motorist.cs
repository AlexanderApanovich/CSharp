using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Lab14
{
    class Motorist : IComparable
    {
        private string mark;
        private int yearofissue;
        private int enginenumber;
        private int bodynumber;
        private string color;
        private int number;
        private string surname;
        private string name;
        private string patronymic;

        public Motorist()
        {
            
            Console.WriteLine("Введите марку автомобиля");
            mark = Console.ReadLine();

            Console.WriteLine("Введите год выпуска");
            yearofissue = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер двигателя");
            enginenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите номер кузова");
            bodynumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите цвет автомобиля");
            color = Console.ReadLine();

            Console.WriteLine("Введите номер автомобиля");
            number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите фамилию");
            surname = Console.ReadLine();

            Console.WriteLine("Введите имя");
            name = Console.ReadLine();

            Console.WriteLine("Введите отчество");
            patronymic = Console.ReadLine();
        }

        public Motorist(string mark,int yearofissue,int enginenumber,int bodynumber,string color,
            int number,string surname,string name,string patronymic)
        {
            this.mark = mark;
            this.yearofissue = yearofissue;
            this.enginenumber = enginenumber;
            this.bodynumber = bodynumber;
            this.color = color;
            this.number = number;
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
        }

        public string Mark
        {
            get { return mark; }
            set { mark = value; }
        }
        public int YearOfIssue
        {
            get { return yearofissue; }
            set { yearofissue = value; }
        }
        public int EngineNumber
        {
            get { return enginenumber; }
            set { enginenumber = value; }
        }
        public int BodyNumber
        {
            get { return bodynumber; }
            set { bodynumber = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Patronymic
        {
            get { return patronymic; }
            set { patronymic = value; }
        }

        public int CompareTo(object obj) //Реализуем сравнение для цвета
        {
            Motorist temp = (Motorist)obj;
            return color.CompareTo(temp.color);
        }
        public void OutputInfo()
        {
            Console.WriteLine("{0}; {1}; {2}; {3}; {4}; {5}; {6}; {7}; {8};", mark,yearofissue,enginenumber,bodynumber,color,number,surname,name,patronymic);
        }
        public override string ToString()
        {
            return mark + ";" + yearofissue + ";" + enginenumber + ";" + bodynumber + ";" + color + ";" + number + ";" + surname
                + ";" + name + ";" + patronymic + ";";
        }
    }
}
