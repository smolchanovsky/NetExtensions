using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays
{
	public static class LastIndexOfExtensions
	{
		public static int LastIndexOf(this Array array, object value)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value);
		}

		public static int LastIndexOf(this Array array, object value, int startIndex)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value, startIndex);
		}

		public static int LastIndexOf(this Array array, object value, int startIndex, int count)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.LastIndexOf(array, value, startIndex, count);
		}
	}
}