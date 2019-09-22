using System;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Arrays.Generics
{
	public static class ResizeExtensions
	{
		public static T[] Resize<T>(this T[] array, int newSize)
		{
			Ensure.IsNotNull(array, nameof(array));

			Array.Resize(ref array, newSize);
			return array;
		}
	}
}