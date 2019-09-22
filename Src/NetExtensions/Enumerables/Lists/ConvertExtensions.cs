using System.Collections.Generic;
using System.Collections.ObjectModel;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Lists
{
	public static class ConvertExtensions
	{
		public static ReadOnlyCollection<T> ToReadOnlyCollection<T>(this IList<T> list)
		{
			Ensure.IsNotNull(list, nameof(list));

			return new ReadOnlyCollection<T>(list);
		}
	}
}