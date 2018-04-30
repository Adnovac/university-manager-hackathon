using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    public class Otoczenie : BuyElements
    {
        int cost;
        string name;
        int status = 0;
        string description;

        public Otoczenie(string name, string description, int cost, int utrzymanie) : base()
        {
            this.cost = cost;
            this.description = description;
            this.name = name;

        }

        public string GetName
        {
            get { return name; }
        }



        public int Status
        {
            set
            {
                status = value;
            }
            get
            {
                return status;
            }
        }
        public override string GetDescription()
        {
            return description;
        }

        public int GetCost
        {
            get
            {
                return cost;
            }
        }
    }
}
