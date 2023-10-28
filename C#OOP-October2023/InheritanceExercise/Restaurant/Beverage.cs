﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    public abstract class Beverage : Product
    {
        public Beverage(string name, decimal price, double milliliters) :
            base(name, price)
        {
            this.milliliters = milliliters;
        }

        public double milliliters { get;private set; }
    }
}
