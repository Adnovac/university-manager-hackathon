using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    public class Wykladwca : BuyElements
    {
        int cost = 5000;
        public Wykladwca() : base() { }

        public override string GetDescription()
        {
            return "Profesor UAM";
        }


        public int Utrzymanie        {
            get
            {
                return cost * 12;
            }
        }



        public string Name
        {
            get
            {
                return "Profesor Stanisław";
            }
        }
    }
}
