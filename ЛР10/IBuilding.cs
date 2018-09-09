using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10
{
    interface IBuilding
    {
        string Name
        {
            get;
            set;
        }
        double Area
        {
            get;
            set;
        }
        int NumberOfFloors
        {
            get;
            set;
        }
    }
}
