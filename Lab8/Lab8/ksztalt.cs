using System;
using System.Collections.Generic;
using System.Text;

namespace powtorzenie_kolos
{
    abstract class ksztalt
    {
        public abstract double X { get; set; }
        public abstract double Y { get; set; }

        public abstract double CountSquare();
        public abstract double CountEnv();

    }
}
