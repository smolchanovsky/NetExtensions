using System.Collections.Generic;
using System.Collections.ObjectModel;
using NetExtensions.Internal;

namespace NetExtensions.Enumerables.Dictionaries
{
	public static class ConvertExtensions
	{
		public static ReadOnlyDictionary<TKey, TValue> ToReadOnlyDictionary<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
		{
			Ensure.IsNotNull(dictionary, nameof(dictionary));

			return new ReadOnlyDictionary<TKey, TValue>(dictionary);
		}
	}
}