using System;
using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
	public static class TakeUntilExtensions
	{
		public static IEnumerable<T> TakeUntil<T>(this IEnumerable<T> enumerable, Predicate<T> predicate)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable.TakeWhile(x => !predicate(x));
		}
	}
}