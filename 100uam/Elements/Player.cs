using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100uam.Elements
{
    public class Player
    {
        string name;
        public int playermoney = 12000000;

        public Player(string name)
        {
            this.name = name;
        }
        public int Playermoney
        {
            get
            {
                return playermoney;
            }
            set
            {
                playermoney = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
        }
    }
}
