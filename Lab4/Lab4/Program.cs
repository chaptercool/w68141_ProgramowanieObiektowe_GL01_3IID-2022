using Lab4.ShapesClasses;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Zad1();
        }

        static void Zad1()
        {
            var shapes = new List<Shape>();
            var shape1 = new Rectangle()
            {
                x = 5,
                width = 2
            };

            shape1.height = 3;

            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });
            shapes.Add(new Rectangle()
            {
                x = 5,
                width = 2
            });

            foreach(var shape in shapes)
            {
                shape.Draw();
            }
            //for (int i = 0; i < shapes.Count; i++)
            //{
            //    shapes[i].Draw();
            //}
        }
    }
}