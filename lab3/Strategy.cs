using System;
using System.Collections.Generic;

namespace lab3
{
	public class Strategy
	{
		public void Create(string[] args)
		{
			if (args.Length == 0)
				throw new ArgumentException("Too few arguments");

			var formulaName = args[0];

			var dictionary =
				new Dictionary<string, object>
				{
					{ "one", 1 },
					{ "two", "two" },
					{ "three", false },
				};

			if (!dictionary.TryGetValue(formulaName, out var value))
				throw new ArgumentException(
					$"Unknown command.{Environment.NewLine}{Environment.NewLine}Supported commands are:{Environment.NewLine}{string.Join(Environment.NewLine, dictionary.Keys)}"
				);

			var o = dictionary[formulaName];
		}
	}
}
