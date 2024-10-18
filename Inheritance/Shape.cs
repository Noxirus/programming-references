namespace ProgrammingOneReferences.Inheritance
{
    // Inheritance is a powerful feature in object oriented programming.
    // This allows us to re-use our functionality in children classes.
    // This can also allow us to extend onto our codebase.
    internal class Shape
    {
        // Acces modifiers can help us control what
        // information is accessible from inside or outside of the class.
        // protected means that child classes have access to this particular variable.
        protected string _shapeName = "Default";

        // We use the virtual keyword when we want child classes to override this functionality.
        // The order public virtual or virtual public does not matter.
        virtual public float GetArea()
        {
            Console.WriteLine("This is the basic shape! We need to create a child to make this specific!");
            return 0;
        }

        virtual public float GetPerimeter()
        {
            Console.WriteLine("This is the basic shape! We need to create a child to make this specific!");
            return 0;
        }

        // We can also override the ToString function that C# likes to use!
        public override string ToString()
        {
            return "Base Object!";
        }
    }
}
