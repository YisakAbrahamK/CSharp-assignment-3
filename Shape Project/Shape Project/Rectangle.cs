namespace Shape_Project
{
    internal class Rectangle : Shape
    {

        public double Length { get; set; }
        public double Width { get; set; }

        public override double calculateArea() => Length * Width;

        public override double calculateParameter() => (2 * Width) + (2 * Length);
    }
}
