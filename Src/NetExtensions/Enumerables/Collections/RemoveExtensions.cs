using System.Collections.Generic;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Collections
{
	public static class CollectionExtensions
	{
		public static ICollection<T> RemoveRange<T>(this ICollection<T> collection, params T[] values)
		{
			Ensure.IsNotNull(collection, nameof(collection));
			Ensure.IsNotNull(values, nameof(values));

			foreach (var value in values)
			{
				collection.Remove(value);
			}

			return collection;
		}

		public static ICollection<T> RemoveRange<T>(this ICollection<T> collection, IEnumerable<T> values)
		{
			Ensure.IsNotNull(collection, nameof(collection));
			Ensure.IsNotNull(values, nameof(values));

			foreach (var value in values)
			{
				collection.Remove(value);
			}

			return collection;
		}
	}
}