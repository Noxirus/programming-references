namespace ProgrammingOneReferences.Inheritance
{
    internal class RightAngleTriangle : Shape
    {
        private float _opposite;
        private float _adjacent;
        private float _hypotenuse;

        public RightAngleTriangle(float opposite, float adjacent)
        {
            _opposite = opposite;
            _adjacent = adjacent;
            _hypotenuse = MathF.Sqrt(MathF.Pow(_opposite, 2) + MathF.Pow(_adjacent, 2));
        }

        public float GetHypotenuse()
        {
            Console.WriteLine($"The hypotenuse of the right angle triangle is: {_hypotenuse}");
            return _hypotenuse;
        }

        override public float GetArea()
        {
            float area = (_adjacent * _opposite) / 2;
            Console.WriteLine($"The area of this triangle is: {area}");
            return area;
        }

        public override float GetPerimeter()
        {
            float perimeter = _adjacent + _opposite + _hypotenuse;
            Console.WriteLine($"The perimeter of this triangle is: {perimeter}");
            return perimeter;
        }
    }
}
