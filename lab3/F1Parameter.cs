using System;

namespace lab3
{
	public class F1Parameter : IParameter
	{
		public double M { get; }
		public double N { get; }

		public F1Parameter(double m, double n)
		{
			if (m < 0)
				throw new ArgumentOutOfRangeException(nameof(m), m, "Argument is less than zero.");

			M = m;
			N = n;
		}
	}
}
