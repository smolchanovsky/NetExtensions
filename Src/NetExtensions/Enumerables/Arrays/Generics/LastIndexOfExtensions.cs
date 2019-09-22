using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays.Generics
{
	public static class LastIndexOfExtensions
	{
		public static int LastIndexOf<T>(this T[] array, T value)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value);
		}

		public static int LastIndexOf<T>(this T[] array, T value, int startIndex)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value, startIndex);
		}

		public static int LastIndexOf<T>(this T[] array, T value, int startIndex, int count)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value, startIndex, count);
		}
	}
}