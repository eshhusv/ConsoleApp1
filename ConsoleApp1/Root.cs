﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Root
    {
        public double A { get; set; }
        public double B { get; set; }

        protected Root(double a, double b)
        {
            A = a;
            B = b;
        }

        public abstract string getSquare();
    }
}