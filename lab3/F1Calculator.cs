namespace lab3
{
	public class F1Calculator : ICalculator<F1Parameter>
	{
		public double Calculate(F1Parameter parameter)
		{
			// calculate formula:
			return parameter.M + parameter.N;
		}

		double ICalculator.Calculate(IParameter parameter)
		{
			return Calculate((F1Parameter) parameter);
		}
	}
}
