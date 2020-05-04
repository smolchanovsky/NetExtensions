using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Randoms
{
	public static class ShuffleExtensions
	{
		public static T[] Shuffle<T>(this IRandom random, IEnumerable<T> items)
		{
			Ensure.IsNotNull(random, nameof(random));
			Ensure.IsNotNull(items, nameof(items));
			
			var collectionItems = items as T[] ?? items.ToArray();
			
			for (var currentIndex = collectionItems.Length - 1; currentIndex > 0; currentIndex--)
			{
				var randomIndex = random.Next(currentIndex + 1);
				var value = collectionItems[randomIndex];
				collectionItems[randomIndex] = collectionItems[currentIndex];
				collectionItems[currentIndex] = value;
			}
			return collectionItems;
		}
	}
}