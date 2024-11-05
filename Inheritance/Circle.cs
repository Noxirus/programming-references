namespace ProgrammingOneReferences.Inheritance
{
    internal class Circle : Shape
    {
        private float _radius;

        public Circle(float radius)
        {
            _radius = radius;
        }

        override public float GetArea()
        {
            float area = MathF.PI * MathF.Pow(_radius, 2);
            Console.WriteLine($"The area of this circle is: {area}");
            return area;
        }

        override public float GetPerimeter()
        {
            float perimeter = 2 * MathF.PI * _radius;
            Console.WriteLine($"The perimeter of this circle is: {perimeter}");
            return perimeter;
        }
    }

    // This is a non fancy comment
    // Another non fancy comment
    // This is a main comment
}
