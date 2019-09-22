using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Collections
{
	public static class AddExtensions
	{
		public static ICollection<T> AddRange<T>(this ICollection<T> collection, params T[] values)
		{
			Ensure.IsNotNull(collection, nameof(collection));
			Ensure.IsNotNull(values, nameof(values));

			foreach (var value in values)
			{
				collection.Add(value);
			}

			return collection;
		}

		public static ICollection<T> AddRange<T>(this ICollection<T> collection, IEnumerable<T> values)
		{
			Ensure.IsNotNull(collection, nameof(collection));
			Ensure.IsNotNull(values, nameof(values));

			foreach (var value in values)
			{
				collection.Add(value);
			}

			return collection;
		}
	}
}