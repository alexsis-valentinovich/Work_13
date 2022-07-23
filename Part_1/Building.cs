using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Building
    {
        string adress;
        int dlina;
        int shirina;
        int vusota;
        int Dlina
        {
            get
            {
                return dlina;
            }
            set
            {
                if (value <= 0)
                {
                    if (value == 0)
                    {
                        dlina = 50;
                    }
                    else
                    {
                        dlina = value * (-1);
                    }
                }
                else
                {
                    dlina = value;
                }
            }
        }

        int Shirina
        {
            get
            {
                return shirina;
            }
            set
            {
                if (value <= 0)
                {
                    if (value == 0)
                    {
                        shirina = 50;
                    }
                    else
                    {
                        shirina = value * (-1);
                    }
                }
                else
                {
                    shirina = value;
                }
            }
        }
        int Vusota
        {
            get
            {
                return vusota;
            }
            set
            {
                if (value <= 0)
                {
                    if (value == 0)
                    {
                        vusota = 50;
                    }
                    else
                    {
                        vusota = value * (-1);
                    }
                }
                else
                {
                    vusota = value;
                }
            }
        }
        public Building(string adress, int dlina, int shirina, int vusota)
        {
            this.adress = adress;
            this.Dlina = dlina;
            this.Shirina = shirina;
            this.Vusota = vusota;
        }
        public string Print()
        {
            return $"Адрес здания: {adress}\nДлина здания: {dlina}\nШирина здания: {shirina}\nВысота здания: {vusota}";
        }
    }
}
