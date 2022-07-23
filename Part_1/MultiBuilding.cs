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
        public MultiBuilding(string adress, int dlina, int shirina, int vusota, int numberFloor)
            : base(adress, dlina, shirina, vusota)
        {
            this.numberFloors = numberFloor;
        }
        public string Print()
        {
            return $"{base.Print()}\nЭтажность здания: {numberFloors}";
        }
    }
}
