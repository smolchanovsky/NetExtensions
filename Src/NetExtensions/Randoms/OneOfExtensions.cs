using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Randoms
{
	public static class OneOfExtensions
	{
		public static T OneOf<T>(this IRandom random, params T[] items)
		{
			Ensure.IsNotNull(random, nameof(random));
			Ensure.IsNotNull(items, nameof(items));

			return items[random.Next(items.Length)];
		}

		public static T OneOf<T>(this IRandom random, IEnumerable<T> items)
		{
			Ensure.IsNotNull(random, nameof(random));
			Ensure.IsNotNull(items, nameof(items));

			var itemsArray = items as T[] ?? items.ToArray();;
			return itemsArray.ElementAt(random.Next(itemsArray.Length));
		}
	}
}