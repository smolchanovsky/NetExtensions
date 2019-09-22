using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
	public static class ConvertExtensions
	{
		public static HashSet<T> ToHashSet<T>(this IEnumerable<T> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return new HashSet<T>(enumerable);
		}

		public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IEnumerable<T> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return Lists.ConvertExtensions.ToReadOnlyCollection(new List<T>(enumerable));
		}

		public static IEnumerable<T> ToEmptyIfNull<T>(this IEnumerable<T> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable ?? Enumerable.Empty<T>();
		}
	}
}