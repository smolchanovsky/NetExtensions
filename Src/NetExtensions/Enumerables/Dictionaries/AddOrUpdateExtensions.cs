using System;
using System.Collections.Generic;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
	public static class AddOrUpdateExtensions
	{
		public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			if (dictionary.ContainsKey(key))
				dictionary[key] = value;
			else
				dictionary.Add(key, value);

			return dictionary[key];
		}

		public static TValue AddOrUpdate<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, KeyValuePair<TKey, TValue> keyValuePair)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			if (dictionary.ContainsKey(keyValuePair.Key))
				dictionary[keyValuePair.Key] = keyValuePair.Value;
			else
				dictionary.Add(keyValuePair);

			return dictionary[keyValuePair.Key];
		}

	}
}