using System;
using Xunit;

namespace FigureCalculationLibrary.UnitTest
{
    public class CircleTest
    {
        /// <summary>
        /// Проверяет что обработчик возвращает площадь круга равной 254.3.
        /// </summary>
        [Fact]
        public void ShapeTest_Return_254_3()
        {
            //Arrange
            Circle circle = new Circle("Круг", 9);
            var expected = 254.47;
            //Act
            var result = circle.Shape();
            //Assert
            Assert.Equal((decimal)expected, Math.Round(result, 2));
        }
        /// <summary>
        /// Проверяет что обработчик возвращает ArgumentException.
        /// </summary>
        [Fact]
        public void ShapeTest_Return_ArgumentException()
        {
            //Assert
            Assert.Throws<ArgumentException>(() =>
                //Arrange
                new Circle("Круг",0));
        }
    }
}
