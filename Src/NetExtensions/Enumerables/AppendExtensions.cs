using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
	public static class AppendExtensions
	{
		public static IEnumerable<T> Append<T>(this IEnumerable<T> enumerable, T item)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable.Concat(new[] { item });
		}
	}
}