using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8 
{
    abstract class PublicBuilding : IBuilding //Абстрактный класс, наследующий интерфейс
    {
        protected string name;
        protected double area;
        protected int numberoffloors;
        protected bool doorsopened;

        public PublicBuilding()
        {

        }
        public PublicBuilding(string name,double area, int numberoffloors)
        {
            this.name = name;
            this.area = area;
            this.numberoffloors = numberoffloors;
        }

        //Реализуем свойства интерфейса
        public string Name
        {
            get { return name; }
            set { value = name; }
        }
        public double Area
        {
            get { return area; }
            set { value = area; }
        }
        public int NumberOfFloors
        {
            get { return numberoffloors; }
            set { value = numberoffloors; }
        }
        public bool DoorsOpened
        {
            get { return doorsopened; }
        }
        public abstract void OpenTheDoor();
        public abstract void CloseTheDoor();
        public override string ToString()
        {
            return "Название:" + name + " Площадь:" + area + " Кол-во этажей:" + numberoffloors;
        }

    }
}
