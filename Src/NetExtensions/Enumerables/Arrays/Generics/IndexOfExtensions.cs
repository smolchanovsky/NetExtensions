using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays.Generics
{
	public static class IndexOfExtensions
	{
		public static int IndexOf<T>(this T[] array, T value)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value);
		}

		public static int IndexOf<T>(this T[] array, T value, int startIndex)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value, startIndex);
		}

		public static int IndexOf<T>(this T[] array, T value, int startIndex, int count)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value, startIndex, count);
		}
	}
}