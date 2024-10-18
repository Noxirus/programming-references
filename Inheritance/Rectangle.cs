namespace ProgrammingOneReferences.Inheritance
{
    // Remember when we are stating the class is a child of something to use: : Shape (or class name)
    // This will now inherit all of the parent functionality of our shape class as well.
    internal class Rectangle : Shape
    {
        // One important concept to consider is trying to keep as many variables and functions private and inaccessible.
        // We want to limit the control of information as much as possible to prevent making mistakes later, or other programmers making mistakes.
        // These are properties, which are private member variables, we control access to them via getters and setters.
        private float _length;
        private float _width;

        public Rectangle(float length, float width)
        {
            _length = length;
            _width = width;
        }

        override public float GetArea()
        {
            float area = _length * _width;
            Console.WriteLine($"The area of this rectangle is: {area}");
            return area;
        }

        public override float GetPerimeter()
        {
            float perimeter = (_length + _width) * 2;
            Console.WriteLine($"The perimeter of this rectangle is: {perimeter}");
            return perimeter;
        }

        public override string ToString()
        {
            return "Rectangle!";
        }
    }
}
