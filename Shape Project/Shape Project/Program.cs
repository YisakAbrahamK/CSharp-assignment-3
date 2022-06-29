namespace Shape_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new ();   //The same as Circle circle = new Circle();
            Rectangle rectangle = new ();

            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter the radious(m) of the circle: ");
            circle.radious = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of the circle is: " + circle.calculateArea() + " meter square");
            Console.WriteLine("The Parameter of the circle is: " + circle.calculateParameter() + " meter");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter the Length(m) of the rectangle: ");
            rectangle.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width(m) of the rectangle: ");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of the rectangle is: " + rectangle.calculateArea() + " meter square");
            Console.WriteLine("The Parameter of the rectangle is: " + rectangle.calculateParameter() + " meter");
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }
}