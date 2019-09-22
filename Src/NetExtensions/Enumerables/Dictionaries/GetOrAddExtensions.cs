using System.Collections.Generic;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
	public static class GetOrAddExtensions
	{
		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			if (!dictionary.ContainsKey(key))
				dictionary.Add(key, value);

			return dictionary[key];
		}

		public static TValue GetOrAdd<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> keyValuePair)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			if (!dictionary.ContainsKey(keyValuePair.Key))
				dictionary.Add(keyValuePair);

			return keyValuePair.Value;
		}
	}
}