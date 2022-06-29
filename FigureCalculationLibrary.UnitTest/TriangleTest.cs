using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace FigureCalculationLibrary.UnitTest
{
    public class TriangleTest
    {
		/// <summary>
		/// Проверяет что обработчик возвращает false. 
		/// </summary>
		[Fact]
		public void IsStraightTrianglTest_ReturnFalse()
		{
			//Arrange
			var triangle = new Triangle("Треугольник", 2, 3, 4);
			//Act
			var result = triangle.isStraightTriangle();
			//Assert
			Assert.False(result);
		}
		/// <summary>
		/// Если такого треугольника не существует(сторона больше суммы двух других), получаем исключение.
		/// </summary>
		[Fact]
		public void ShapeTest_Return_TriangleException()
		{
			//Assert
			Assert.Throws<TriangleException>(() =>
				//Arrange
				new Triangle("Треугольник", 3, 5, 9));
		}
		/// <summary>
		/// Если такого треугольника не существует(сторона(ы) меньше 0), получаем исключение.
		/// </summary>
		[Fact]
		public void ShapeTest_Return_TriangleException_smaller0()
		{
			//Act
			Action act = () => new Triangle("Треугольник", -1, -1, -1);
			//Assert
			TriangleException exception = Assert.Throws<TriangleException>(act);
			Assert.Equal("Такого треугольника не существует(сторона(ы) меньше 0)", exception.Message);
		}
		/// <summary>
		/// Проверяет что обработчик возвращает площадь треугольника равной 12.
		/// </summary>
		[Fact]
		public void ShapeTest_Return_12()
		{
			//Arrange
			var triangle = new Triangle("Треугольник", 5, 8, 5);
			var expected = 12;
			//Act
			var result = triangle.Shape();
			//Assert
			Assert.Equal(expected, result);
		}
	}
}
