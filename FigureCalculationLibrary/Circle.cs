
namespace FigureCalculationLibrary
{
	public class Circle : BaseBillet
	{
		public double Radius { get; private set; }
		public Circle(string typeName, double radius) : base(typeName)
		{
            if (radius>0)
            {
				Radius = radius;
			}
            else
            {
				throw new ArgumentException("Введино не корректное значение радиуса круга");
			}
		}
		public override decimal Shape()
		{
			return (decimal)(Math.PI * Math.Pow(Radius, 2));
		}
	}
}
