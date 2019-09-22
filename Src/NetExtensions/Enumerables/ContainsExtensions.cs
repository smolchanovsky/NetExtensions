using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
	public static class ContainsExtensions
	{
		public static bool ContainsAll<T>(this IEnumerable<T> enumerable, params T[] values)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));
			Ensure.IsNotNull(values, nameof(values));

			return values.All(enumerable.Contains);
		}

		public static bool ContainsAll<T>(this IEnumerable<T> enumerable, IEnumerable<T> values)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));
			Ensure.IsNotNull(values, nameof(values));

			return values.All(enumerable.Contains);
		}

		public static bool ContainsAny<T>(this IEnumerable<T> enumerable, params T[] values)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));
			Ensure.IsNotNull(values, nameof(values));

			return values.Any(enumerable.Contains);
		}

		public static bool ContainsAny<T>(this IEnumerable<T> enumerable, IEnumerable<T> values)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));
			Ensure.IsNotNull(values, nameof(values));

			return values.Any(enumerable.Contains);
		}
	}
}