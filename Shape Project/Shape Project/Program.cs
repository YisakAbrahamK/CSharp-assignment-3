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
            Console.WriteLine("The Area of the circle is: " + Math.Round(circle.calculateArea(),2) + " meter square");
            Console.WriteLine("The Parameter of the circle is: " + Math.Round(circle.calculateParameter(),2) + " meter");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write("Enter the Length(m) of the rectangle: ");
            rectangle.Length = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the width(m) of the rectangle: ");
            rectangle.Width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The Area of the rectangle is: " + Math.Round(rectangle.calculateArea(),2) + " meter square");
            Console.WriteLine("The Parameter of the rectangle is: " + Math.Round(rectangle.calculateParameter(), 2) + " meter");
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }
}