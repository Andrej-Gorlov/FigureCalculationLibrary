namespace FigureCalculationLibrary
{
    public abstract class BaseBillet
	{
		public string TypeName { get; private set; }

		protected BaseBillet(string typeName)
		{
			TypeName = typeName;
		}
		public abstract decimal Shape();
		public override string ToString() => $"Текущий тип фигуры: " + TypeName;
	}
}
