using System;
using System.Collections.Generic;
using System.Linq;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
    public static class GetExtensions
    {
		public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return GetValueOrDefault(dictionary, key, default);
		}

		public static TValue GetOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, Func<TValue> defaultValueFunc)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));
			Ensure.IsNotNull(defaultValueFunc, nameof(defaultValueFunc));

			return GetValueOrDefault(dictionary, key, defaultValueFunc());
		}

		public static TValue GetValueOrDefault<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue defaultValue)
		{
			return dictionary.TryGetValue(key, out var result) ? result : defaultValue;
		}

		public static IEnumerable<TKey> GetKeys<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return dictionary.Select(x => x.Key);
		}
	}
}