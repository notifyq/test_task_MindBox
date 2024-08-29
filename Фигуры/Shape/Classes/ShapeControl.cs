using Shape.Interfaces;

namespace Shape.Classes
{
    /// <summary>
    /// Класс создания фигур. Для обращения используем свойство Instance.
    /// Вижу возможность добавления библиотеки например к wpf проекту 
    /// для визуального отображения фигур и перемещению их по окну.
    /// </summary>
    public class ShapeControl
    {
        public static ShapeControl Instance { get; } = new ShapeControl();
        private ShapeControl() { }

        public IShape CreateCircle(double radius) // Круг
        {
            return new Shapes.Circle(radius);
        }
        public IShape CreateTriangle(double A, double B, double C) // Треугольник
        {
            return new Shapes.Triangle(A, B, C);
        }
    }
}
