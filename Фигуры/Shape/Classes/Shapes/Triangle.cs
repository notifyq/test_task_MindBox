using Shape.Interfaces;
namespace Shape.Classes.Shapes
{
    public class Triangle: IShape
    {
        private readonly double _sideA;
        private readonly double _sideB;
        private readonly double _sideC;

        public Triangle(double sideA, double sideB, double sideC)
        {
            if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            {
                throw new ArgumentException("Стороны треугольника должны быть положительными");

            }
            if (sideA + sideB <= sideC || sideA + sideC <= sideB || sideB + sideC <= sideA) // сторона треугольника должна быть меньше суммы двух других
            {
                throw new ArgumentException("Стороны не могут образовать треугольник");
            }

            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
        }
        public double CalcArea() 
        {
            // формула площади треугольника по трём сторонам sqrt(p) · (p — a)(p — b)(p — c), где p - половина периметра 
            double halfPerimeter = (_sideA + _sideB + _sideC) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - _sideA) * (halfPerimeter - _sideB) * (halfPerimeter - _sideC));
            return area;
        }
        public bool IsRightTriangle() // Теорема Пифагора: a^2 + b^2 = c^2
        {
            double squareA = Math.Pow(_sideA, 2);
            double squareB = Math.Pow(_sideB, 2);
            double squareC = Math.Pow(_sideC, 2);

            return 
                (squareA + squareB == squareC) || 
                (squareA + squareC == squareB) || 
                (squareB + squareC == squareA);   
        }
    }
}
