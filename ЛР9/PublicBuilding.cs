using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    abstract class PublicBuilding : IBuilding
    {
        protected string name;
        protected double area;
        protected int numberoffloors;
        protected bool doorsopened;

        public PublicBuilding()
        {

        }
        public PublicBuilding(string name, double area, int numberoffloors)
        {
            this.name = name;
            this.area = area;
            this.numberoffloors = numberoffloors;
        }
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
