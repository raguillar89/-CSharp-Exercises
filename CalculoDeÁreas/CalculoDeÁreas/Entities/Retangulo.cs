using CalculoDeÁreas.Entities.Enums;

namespace CalculoDeÁreas.Entities
{
    class Retangulo : Shape
    {
        public double Width { get; set; }
        public double Heigh { get; set; }

        public Retangulo(double width, double height, Color color) : base(color)
        {
            Width = width;
            Heigh = height;
        }

        public override double Area()
        {
            return Width * Heigh;
        }
    }
}
