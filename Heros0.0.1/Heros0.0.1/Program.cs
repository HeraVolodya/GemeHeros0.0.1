﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heros0._0._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SuperPowerGenerator superPowerGenerator = new SuperPowerGenerator();
            Console.WriteLine(superPowerGenerator.Random());
        }
    }
}
