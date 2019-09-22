using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays.Generics
{
	public static class ReverseExtensions
	{
		public static void Reverse(this Array array)
		{
			Ensure.IsNotNull(array, nameof(array));

			Array.Reverse(array);
		}

		public static void Reverse(this Array array, int index, int length)
		{
			Ensure.IsNotNull(array, nameof(array));

			Array.Reverse(array, index, length);
		}
	}
}