using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
	public static class ContainsExtensions
	{
		public static bool ContainsAllKeys<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, params TKey[] keys)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return keys.All(dictionary.ContainsKey);
		}

		public static bool ContainsAllKeys<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<TKey> keys)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return keys.All(dictionary.ContainsKey);
		}

		public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, params TKey[] keys)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return keys.Any(dictionary.ContainsKey);
		}

		public static bool ContainsAnyKey<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IEnumerable<TKey> keys)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return keys.Any(dictionary.ContainsKey);
		}
	}
}