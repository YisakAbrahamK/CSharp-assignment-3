namespace Shape_Project
{
    internal class Circle : Shape
    {
        public static readonly double  PI=3.14;
        public double radious { get; set; }

        public override double calculateArea() => 2 * PI* radious * radious;

        public override double calculateParameter() => 2 * PI* radious;

    }
}
