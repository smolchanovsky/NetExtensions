using System;
using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Randoms
{
	public static class OneOfExtensions
	{
		public static T OneOf<T>(this Random random, params T[] values)
		{
			Ensure.IsNotNull(random, nameof(random));
			Ensure.IsNotNull(values, nameof(values));

			return values[random.Next(values.Length)];
		}

		public static T OneOf<T>(this Random random, IEnumerable<T> values)
		{
			Ensure.IsNotNull(random, nameof(random));
			Ensure.IsNotNull(values, nameof(values));

			var valuesArray = values.ToArray();
			return valuesArray.ElementAt(random.Next(valuesArray.Length));
		}
	}
}