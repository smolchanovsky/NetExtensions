using System.Collections.Generic;
using NetExtensions.Internal;

namespace NetExtensions.Strings
{
	public static class StringJoinExtensions
	{
		public static string JoinStrings<T>(this IEnumerable<T> values, string separator)
		{
			Ensure.IsNotNull(values, nameof(values));
			Ensure.IsNotNull(separator, nameof(separator));

			return string.Join(separator, values);
		}

		public static string JoinStrings<T>(this IEnumerable<T> values)
		{
			Ensure.IsNotNull(values, nameof(values));

			return JoinStrings(values, separator: string.Empty);
		}
	}
}