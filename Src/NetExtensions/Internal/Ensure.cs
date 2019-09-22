using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace NetExtensions.Internal
{
	internal class Ensure
	{
		public static T IsNotNull<T>([NoEnumeration] T value, string paramName) where T : class
		{
			if (value == null)
				throw new ArgumentNullException(paramName, "Value cannot be null.");

			return value;
		}

		public static string IsNotNullOrEmpty(string str, string paramName)
		{
			if (str == null)
				throw new ArgumentNullException(paramName, "Value cannot be null.");
			if (str.Length == 0)
				throw new ArgumentException("Value cannot be empty.", paramName);
			
			return str;
		}

		public static ICollection<T> IsNotNullOrEmpty<T>(ICollection<T> collection, string paramName)
		{
			if (collection == null)
				throw new ArgumentNullException(paramName, "Value cannot be null.");
			if (!collection.Any())
				throw new ArgumentException("Value cannot be empty.", paramName);

			return collection;
		}
	}
}