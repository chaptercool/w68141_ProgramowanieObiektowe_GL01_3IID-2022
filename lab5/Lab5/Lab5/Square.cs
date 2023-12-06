using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Square : Shape
    {
        public double X { get; set; }
        //public double Y { get; set; }

        public override double Calculate()
        {
            return Math.Pow(X, 2);
        }
    }
}
