using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab14
{
    class MotoristsList
    {        
        private Motorist[] motorists;

        public MotoristsList(Motorist[] motorists)
        {
            this.motorists = motorists;
            FileStream file = new FileStream("labfile.txt", FileMode.Append);
            StreamWriter fnew = new StreamWriter(file);
            for (int i = 0; i < motorists.Count(); i++)
            {
                fnew.WriteLine("Автомобилист" + i + ":" + motorists[i].ToString());
            }
            fnew.Close();
        }
        public MotoristsList(int n)
        {
            FileStream file = new FileStream("labfile.txt", FileMode.Append);
            StreamWriter fnew = new StreamWriter(file);
            motorists = new Motorist[n];
            for(int i=0;i<n;i++)
            {
                
                Console.WriteLine("Введите автолюбителя №{0}", i);
                motorists[i] = new Motorist();                
                fnew.WriteLine("Автомобилист" + i + ":" + motorists[i].ToString());
            }
            fnew.Close();
        }

        public Motorist[] Motorists
        {
            get { return motorists; }
            set { motorists = value;}
        }

        public void OutputInfo()
        {
            FileStream file = new FileStream("labfile.txt", FileMode.Append);
            StreamWriter fnew = new StreamWriter(file);
            foreach (Motorist el in motorists)
            {
                fnew.WriteLine(el);
                el.OutputInfo();
            }
            fnew.Close();
        }
        public void AgeFilter(int year)
        {
            int count=0, average = 0;
            foreach (Motorist el in motorists) //Находим сумму лет эксплуатации автомобилей
            {
                average += year - el.YearOfIssue;
            }
            average = average / motorists.Length; //Находим среднее арифметическое эксплуатации
            FileStream file = new FileStream("labfile.txt", FileMode.Append);
            StreamWriter fnew = new StreamWriter(file);
            Console.WriteLine("Фамилии владельцев автомобилей с момента выпуска которых прошло более среднего возраста автомобилей");
            fnew.WriteLine("Фамилии владельцев автомобилей с момента выпуска которых прошло более среднего возраста автомобилей");
            foreach (Motorist el in motorists) //Проверяем каждый автомобиль на превышение среднего срока и если верно то выводим
            {
                if(year-el.YearOfIssue>average)
                {
                    count++;
                    Console.WriteLine(el.Surname);
                    fnew.WriteLine(el.Surname);
                }                    
            }
            Console.WriteLine("Количество автомобилей с момента выпуска которых прошло более среднего возраста автомобилей : {0}",count);
            fnew.WriteLine("Количество автомобилей с момента выпуска которых прошло более среднего возраста автомобилей : {0}", count);
            fnew.Close();
        }      
        public void ChosenMarkSameColor()
        {
            Console.WriteLine("Введите марку");
            string chosenmark = Console.ReadLine();
            List<Motorist> temp = new List<Motorist>();
            for(int i=0;i<motorists.Count();i++) //Сначала добавляем в новый список только тех автолюбителей которые соответствуют заданой марке
            {
                if(motorists[i].Mark==chosenmark)
                {
                    temp.Add(motorists[i]);
                }
            }
            temp.Sort(); //Сортируем получившийся список по цвету
            FileStream file = new FileStream("lab14file.txt", FileMode.Append);
            StreamWriter fnew = new StreamWriter(file);
            string tempcolor = temp[0].Color; //В качестве временного цвета присваиваем первый
            Console.WriteLine("Автомобилисты имеющие марку " + chosenmark + " и " + tempcolor + " цвет:"); //Выводим всех с первым цветом в списке(далее в цикле идет условие)
            fnew.WriteLine("Автомобилисты имеющие марку " + chosenmark + " и " + tempcolor + " цвет:");
            for (int i=0;i<temp.Count;i++)
            {
                if(temp[i].Color==tempcolor) //Как только цвет не соответствует предыдущему выводу идем в else где присваиваем временному текущий и продолжаем выводить
                {
                    Console.WriteLine(temp[i].Surname+";");
                    fnew.WriteLine(temp[i].Surname + ";");
                }
                else
                {                   
                    tempcolor = temp[i].Color;
                    Console.WriteLine("Автомобилисты имеющие марку " + chosenmark + " и " + tempcolor + " цвет:");
                    fnew.WriteLine("Автомобилисты имеющие марку " + chosenmark + " и " + tempcolor + " цвет:");
                    Console.WriteLine(temp[i].Surname + ";");
                    fnew.WriteLine(temp[i].Surname + ";");
                }
            }
            fnew.Close();
        }
    }
}