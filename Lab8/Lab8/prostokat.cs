using System;
using System.Collections.Generic;
using System.Text;

namespace powtorzenie_kolos
{
    class prostokat : ksztalt
    {
        public override double X { get; set; }
        public override double Y { get; set; }

        public square(double x, double y)
        {
            X = x;
            Y = y;
        }

        public override double CountSquare()
        {
            return X * Y;
        }

        public override double CountEnv()
        {
            return 2 * (X + Y);
        }
    }
}
