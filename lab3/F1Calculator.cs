namespace lab3
{
	public class F1Calculator : ICalculator
	{
		public double Calculate(IParameter parameter)
		{
			return Calculate((F1Parameter) parameter);
		}

		private static double Calculate(F1Parameter parameter)
		{
			// calculate formula:
			return parameter.M + parameter.N;
		}
	}
}
