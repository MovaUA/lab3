using System;

namespace lab3
{
	public class F1ParameterFactory : IParameterFactory<F1Parameter>
	{
		public F1Parameter Create(string[] args)
		{
			// parsing:

			if (args.Length != 2)
				throw new ArgumentException($"Invalid number or arguments, expected 2, got {args.Length}.");

			if (!double.TryParse(args[0], out var m))
				throw new ArgumentException($"Invalid {nameof(F1Parameter.M)}.");

			if (!double.TryParse(args[1], out var n))
				throw new ArgumentException($"Invalid {nameof(F1Parameter.N)}.");

			return new F1Parameter(m, n);
		}
	}
}