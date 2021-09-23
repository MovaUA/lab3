using System;
using System.Collections.Generic;
using System.Linq;

namespace lab3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var supportedFormulas =
				new Dictionary<string, (IParameterFactory parameterFactory, ICalculator calculator)>
				{
					{ "one", (new F1ParameterFactory(), new F1Calculator()) },
					{ "two", (new F1ParameterFactory(), new F1Calculator()) },
				};

			try
			{
				if (args.Length == 0)
					throw new ArgumentException(
						$"Usage:{Environment.NewLine}{string.Join(Environment.NewLine, supportedFormulas.Keys)}"
					);

				var formulaName = args[0];

				if (!supportedFormulas.TryGetValue(formulaName, out var tuple))
					throw new ArgumentException(
						$"Unknown command.{Environment.NewLine}{Environment.NewLine}Usage:{Environment.NewLine}{string.Join(Environment.NewLine, supportedFormulas.Keys)}"
					);

				var (parameterFactory, calculator) = tuple;

				var parameter = parameterFactory.Create(
					args: args.Skip(1).ToArray()
				);

				var result = calculator.Calculate(parameter);
			}
			catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
		}
	}
}
