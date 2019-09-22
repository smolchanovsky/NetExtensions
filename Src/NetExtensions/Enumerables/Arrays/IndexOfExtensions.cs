using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays
{
	public static class IndexOfExtensions
	{
		public static int IndexOf(this Array array, object value)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value);
		}

		public static int IndexOf(this Array array, object value, int startIndex)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value, startIndex);
		}

		public static int IndexOf(this Array array, object value, int startIndex, int count)
		{
			Ensure.IsNotNull(array, nameof(array));

			return Array.IndexOf(array, value, startIndex, count);
		}
	}
}