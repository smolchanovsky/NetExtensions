using System;
using NetExtensions.Internal;

namespace NetExtensions.Strings
{
    public static class TruncateExtensions
	{
		public static string Truncate(this string str, int size)
        {
			Ensure.IsNotNull(str, nameof(str));

			if (str.Length > size)
				throw new ArgumentOutOfRangeException(nameof(size));

            return str.Substring(0, size);
        }
    }
}