using CalculoDeÁreas.Entities.Enums;

namespace CalculoDeÁreas.Entities
{
    class Circulo : Shape
    {
        public double Radius { get; set; }

        public Circulo(double radius, Color color) : base(color)
        {
            Radius = radius;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
