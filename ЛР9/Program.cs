using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Part2
{
    struct MeanOfCommunication : IComparable
    {
        public string type;
        public double range;
        public double priceperminute;

        public MeanOfCommunication(string type,double range,double priceperminute)
        {
            this.type = type;
            this.range = range;
            this.priceperminute = priceperminute;
        }
        public int CompareTo(object obj) //CompareTo для радиуса действия
        {
            MeanOfCommunication temp = (MeanOfCommunication)obj;
            return range.CompareTo(temp.range);
        }
        public void InputMean()
        {
            Console.WriteLine("Введите тип");
            type = Console.ReadLine();
            Console.WriteLine("Введите радиус действия");
            range = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите цену за минуту");
            priceperminute = Convert.ToDouble(Console.ReadLine());
        }
        public void OutputMean()
        {
            Console.WriteLine("Тип:{0} ; Радиус действия:{1} ; Цена за минуту: {2} ;", type, range, priceperminute);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MeansOfCommunication k = new MeansOfCommunication(3);
            k.OutputMeans();
            k.MaxRange();
            double avprice = k.AveragePricePerHour("телефон");
            Console.WriteLine(avprice);

            Console.ReadKey();
        }
    }
}
