using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros0._0._1
{
    public class SuperPowerGenerator
    {
        public int SuperRandom()
        {
            Random rnd = new Random();
            int suoerPower = rnd.Next(5,10);
            return suoerPower;
        }
    }
}
