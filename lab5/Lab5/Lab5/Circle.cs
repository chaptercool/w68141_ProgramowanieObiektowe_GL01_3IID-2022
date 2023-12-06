namespace Lab5
{
    class Circle : Shape
    {
        public double R { get; set; }

        public Circle(double r)
        {
            R = r;
        }
        public override double Calculate()
        {
            return Math.PI * Math.Pow(R, 2);
        }
    }
}
