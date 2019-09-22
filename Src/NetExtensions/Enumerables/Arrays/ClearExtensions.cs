using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays
{
	public static class ClearExtensions
	{
		public static void Clear(this Array array, int index, int length)
		{
			Ensure.IsNotNull(array, nameof(array));

			Array.Clear(array, index, length);
		}

		public static void ClearAll(this Array array)
		{
			Ensure.IsNotNull(array, nameof(array));

			Array.Clear(array, 0, array.Length);
		}
	}
}