namespace ProgrammingOneReferences.Inheritance
{
    internal class ShapeCode
    {
        // By using the parent class we can put all of our shapes into a single container.
        // But still allow them to execute their own functionality.
        // In this example its specific to returning their area and perimeter.
        public static void ExecuteShapeCode()
        {
            Shape rectangle = new Rectangle(5.0f, 5.0f);
            Shape triangle = new RightAngleTriangle(5.0f, 5.0f);
            Shape circle = new Circle(5.0f);

            List<Shape> shapes = new List<Shape>();
            shapes.Add(rectangle);
            shapes.Add(triangle);
            shapes.Add(circle);

            Console.WriteLine(circle.ToString());

            foreach (Shape shape in shapes)
            {
                shape.GetPerimeter();
                shape.GetArea();

                if (shape is RightAngleTriangle actualTriangle)
                {
                    actualTriangle.GetHypotenuse();
                }

                Console.WriteLine();
            }
        }
    }
}
