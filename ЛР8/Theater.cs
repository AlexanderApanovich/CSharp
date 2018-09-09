using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Theater : PublicBuilding //Класс,наследующий абстрактный класс
    {
        private string scene;
        public Theater()
        {

        }
        public Theater(string name,double area,int numberoffloors,string scene) :base(name,area,numberoffloors) //Конструктор наследуется
        {
            this.scene = scene;
        }
        public string Scene
        {
            get { return scene; }
            set { scene = value; }
        }
        //Реализуем все методы абстрактного класса
        public override void OpenTheDoor()
        {
            Console.WriteLine("Дверь " + name + " открыта");
            doorsopened = true;
        }
        public override void CloseTheDoor()
        {
            Console.WriteLine("Дверь "+name+" закрыта");
            doorsopened = false;
        }
        public override string ToString()
        {
            return base.ToString()+" Сцена:"+scene;
        }
    }
}
