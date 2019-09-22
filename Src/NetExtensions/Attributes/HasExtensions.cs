using System;
using System.Linq;
using System.Reflection;
using NetExtensions.Internal;

namespace NetExtensions.Attributes
{
	public static class AttributeExtensions
	{
		public static bool HasAttribute<T>(this MemberInfo memberInfo, bool inherit = false) where T : Attribute
		{
			Ensure.IsNotNull(memberInfo, nameof(memberInfo));

			return memberInfo.HasAttribute(typeof(T), inherit);
		}

		public static bool HasAttribute(this MemberInfo memberInfo, Type attributeType, bool inherit = false)
		{
			Ensure.IsNotNull(memberInfo, nameof(memberInfo));

			if (attributeType is null)
				throw new ArgumentNullException(nameof(attributeType));
			if (attributeType != typeof(Attribute))
				throw new ArgumentException("Is not an attribute.", nameof(attributeType));

			return memberInfo.GetCustomAttributes(attributeType, inherit).Any();
		}
	}
}