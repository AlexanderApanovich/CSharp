using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9Part2
{
    class MeansOfCommunication
    {
        public MeanOfCommunication[] means; //Как поле имеем массив из средств коммуникации

        public MeansOfCommunication() { }
        public MeansOfCommunication(int k) //Конструктор с ручным вводом элементов массива
        {
            means = InputMeans(k);
        }
        public MeansOfCommunication(MeanOfCommunication[] means) //Конструктор, принимающий готовый массив
        {
            this.means = means;
        }

        public MeanOfCommunication[] InputMeans(int k)
        {
            MeanOfCommunication[] means = new MeanOfCommunication[k];
            for(int i =0;i<means.Length;i++)
            {
                Console.WriteLine("Введите средство №{0}:", i);
                means[i].InputMean();
            }
            return means;
        }
        public void OutputMeans()
        {
            for (int i = 0; i < means.Length; i++)
            {
                Console.WriteLine("Cредство №{0}:", i);
                means[i].OutputMean();
            }
        }
        public double AveragePricePerHour(string type)
        {
            double averageprice=0,c=0;
            for (int i = 0; i < means.Length; i++)
            {
                if(means[i].type==type)
                {
                    c++;
                    averageprice += means[i].priceperminute;
                }
            }
            return averageprice / c * 60;
        }
        public void MaxRange()
        {
            means.Max().OutputMean(); //Находим максимальное, благодаря реализации CompareTo для поля range
        }
    }
}