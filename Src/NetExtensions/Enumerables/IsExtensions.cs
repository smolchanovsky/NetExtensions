using System;
using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
    public static class IsExtensions
    {
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable == null || !enumerable.Any();
		}

		public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return !enumerable.IsNullOrEmpty();
		}
	}
}
