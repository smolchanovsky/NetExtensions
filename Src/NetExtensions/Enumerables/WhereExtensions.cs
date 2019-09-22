using System;
using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables
{
	public static class WhereExtensions
	{
		public static IEnumerable<T> WhereNotNull<T>(this IEnumerable<T> enumerable) where T : class
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable.Where(item => item != null);
		}

		public static IEnumerable<T> WhereNotNull<T, TMember>(this IEnumerable<T> enumerable, Func<T, TMember> memberSelector)
			where T : class
			where TMember : class
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));
			Ensure.IsNotNull(memberSelector, nameof(memberSelector));

			return enumerable.Where(item => memberSelector(item) != null);
		}

		public static IEnumerable<T?> WhereHasValue<T>(this IEnumerable<T?> enumerable) where T : struct
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable.Where(item => item.HasValue);
		}

		public static IEnumerable<string> WhereNotEmpty(this IEnumerable<string> enumerable)
		{
			Ensure.IsNotNull(enumerable, nameof(enumerable));

			return enumerable.Where(item => !string.IsNullOrEmpty(item));
		}
	}
}