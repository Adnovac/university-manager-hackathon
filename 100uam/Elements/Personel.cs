using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    public class Personel : BuyElements
    {
        int cost = 1600;
        public Personel() : base()
        { }

        public override string GetDescription()
        {
            return "Pracownik sprzątający UAM";
        }

        public int Utrzymanie
        {
            get
            {
                return cost * 12;
            }
        }

        public int Zadowolenie
        {
            get
            {
                return 5;
            }
        }

        public string Name
        {
            get
            {
                return "Pan Zbigniew";
            }
        }
    }
}
