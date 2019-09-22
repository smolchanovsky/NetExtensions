using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using NetExtensions.Internal;

namespace NetExtensions.Attributes
{
	public static class DisplayNameExtensions
	{
		public static string GetDisplayName(this MemberInfo memberInfo, bool inherit = false)
		{
			Ensure.IsNotNull(memberInfo, nameof(memberInfo));

			var attributeOrNull = memberInfo
				.GetCustomAttributes(typeof(DisplayNameAttribute), inherit)
				.FirstOrDefault();

			if (attributeOrNull is DisplayNameAttribute displayNameAttribute)
				return displayNameAttribute.DisplayName;
			throw new InvalidOperationException("Member does not have DisplayNameAttribute.");
		}
	}
}