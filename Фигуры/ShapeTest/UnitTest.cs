using Shape.Classes;
using Shape.Classes.Shapes;

namespace ShapeTest
{
    public class UnitTest
    {
        [Fact]
        public void CircleCalcArea()
        {
            double radius = 4;
            double expectedResult = 50.26548245743669;

            var circle = ShapeControl.Instance.CreateCircle(radius);
            double factResut = circle.CalcArea();

            Assert.Equal(expectedResult, factResut);
        }
        [Fact]
        public void TriangleCalcArea()
        {
            double a = 10;
            double b = 10;
            double c = 16;
            double expectedResult = 48;

            var triangle = ShapeControl.Instance.CreateTriangle(a, b, c);
            double factResut = triangle.CalcArea();

            Assert.Equal(expectedResult, factResut);
        }

        [Fact]
        public void TriangleIsRight()
        {
            double a = 12;
            double b = 9;
            double c = 15;

            bool expectedResult = true;

            Triangle triangle = ShapeControl.Instance.CreateTriangle(a, b, c) as Triangle;

            Assert.NotNull(triangle);

            bool factResult = triangle.IsRightTriangle();
            Assert.Equal(expectedResult, factResult);
        }
        [Fact]
        public void InvalidTriangleIsRight()
        {
            double a = 12;
            double b = 9;
            double c = 15;

            bool expectedResult = true;

            Triangle triangle = ShapeControl.Instance.CreateTriangle(a, b, c) as Triangle;

            Assert.NotNull(triangle);

            bool factResult = triangle.IsRightTriangle();
            Assert.Equal(expectedResult, factResult);
        }
        [Fact]
        public void InvalidTriangleParametrs_ThrowArgumentException()
        {
            double a = 3;
            double b = 3;
            double c = 12;

            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var triangle = ShapeControl.Instance.CreateTriangle(a, b, c);
            });
            Assert.Contains("Стороны не могут образовать треугольник", exception.Message);
        }
        [Fact]
        public void InvalidTriangleParametrs_ThrowArgumentException2()
        {
            double a = -1;
            double b = -1;
            double c = -1;

            var exception = Assert.Throws<ArgumentException>(() =>
            {
                var triangle = ShapeControl.Instance.CreateTriangle(a, b, c);
            });
            Assert.Contains("Стороны треугольника должны быть положительными", exception.Message);
        }
        [Fact]
        public void InvalidCircleRadius_ThrowArgumentException()
        {
            double radius = -4;
            var exception = Assert.Throws<ArgumentException>(() => 
            {
                var circle = ShapeControl.Instance.CreateCircle(radius);
            });
            Assert.Contains("Радиус должен быть положительным", exception.Message);
        }
    }
}