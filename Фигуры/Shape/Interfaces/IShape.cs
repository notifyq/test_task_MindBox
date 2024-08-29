namespace Shape.Interfaces
{
   /// <summary>
   /// Интерфейс для фигур
   /// </summary>
    public interface IShape
    {
        /// <summary>
        /// Подсчет площади фигуры
        /// Будем считать что величины фигуры не могут быть отрицательными.
        /// </summary>
        /// <returns>Площадь фигуры, м2</returns>
        public double CalcArea();
    }
}
