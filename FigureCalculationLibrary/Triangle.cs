namespace FigureCalculationLibrary
{
	public class Triangle : BaseBillet
	{
		public double EdgeA { get; private set; }
		public double EdgeB { get; private set; }
		public double EdgeC { get; private set; }
		public Triangle(string typeName, double a, double b, double c) : base(typeName)
		{
			if (isExist(a, b, c))
			{
				EdgeA = a;
				EdgeB = b;
				EdgeC = c;
			}
		}
		public override decimal Shape()
		{
			var p = (EdgeA + EdgeB + EdgeC) / 2;
			return (decimal)Math.Sqrt(p * (p - EdgeA) * (p - EdgeB) * (p - EdgeC));
		}
		private bool isExist(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new TriangleException("Такого треугольника не существует(сторона(ы) меньше 0)");
			}
			if (a > (b + c) || b > (a + c) || c > (a + b))
			{
				throw new TriangleException("Такого треугольника не существует(сторона больше суммы двух других)");
			}
			return true;
		}
		public bool isStraightTriangle()
		{
			bool isStraight = (EdgeA == Math.Sqrt(Math.Pow(EdgeB, 2) + Math.Pow(EdgeC, 2))
							   || EdgeB == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeC, 2))
							   || EdgeC == Math.Sqrt(Math.Pow(EdgeA, 2) + Math.Pow(EdgeB, 2)));
			return isStraight;
		}
	}
}
