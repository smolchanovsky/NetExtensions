using System.Collections.Generic;
using NetExtensions.Enumerables.Dictionaries.KeyValuePairs;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
	public static class AddRangeExtensions
	{
		public static IDictionary<TKey, TValue> AddRange<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, IDictionary<TKey, TValue> otherDictionary)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));
			Ensure.IsNotNull(otherDictionary, nameof(otherDictionary));

			foreach (var (key, value) in otherDictionary)
			{
				dictionary.Add(key, value);
			}

			return dictionary;
		}
	}
}