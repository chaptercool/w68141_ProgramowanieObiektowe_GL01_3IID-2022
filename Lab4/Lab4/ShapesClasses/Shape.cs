namespace Lab4.ShapesClasses
{
    public class Shape
    {
        public int x { get; set; }
        public int y { get; set; }
        public int height { get; set; }
        public int width { get; set; }

        public virtual void Draw()
        {
            Console.WriteLine("Shape");
        }
    }

}
