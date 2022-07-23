using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class MultiBuilding : Building
    {
        int numberFloors;
        int NumberFloors
        {
            get
            {
                return numberFloors;
            }
            set
            {
                if (value < 0)
                {
                        numberFloors = value * (-1);
                }
                else
                {
                    numberFloors = value;
                }
            }
        }
        public MultiBuilding(string adress, int dlina, int shirina, int vusota, int numberFloor)
            : base(adress, dlina, shirina, vusota)
        {
            this.NumberFloors = numberFloor;
        }
        public string Print()
        {
            return $"{base.Print()}\nЭтажность здания: {numberFloors}";
        }
    }
}
