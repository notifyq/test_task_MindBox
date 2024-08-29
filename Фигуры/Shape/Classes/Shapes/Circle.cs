using Shape.Interfaces;

namespace Shape.Classes.Shapes
{
    public class Circle: IShape
    {
        private readonly double _radius;
        public double Radius
        {
            get { return _radius; }
        }
        public Circle(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Радиус должен быть положительным");
            }
            else
            {
                _radius = radius;
            }
        }
        public double CalcArea() /// PI*R^2
        {
            double area = Math.PI * Radius * Radius;
            return area;
        }
    }
}
