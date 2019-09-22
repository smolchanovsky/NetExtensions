using System;

namespace NetExtensions.Chars
{
	public static class ParseExtensions
	{
		public static bool IsDigit(this char c)
		{
			return Char.IsDigit(c);
		}

		public static bool IsLetter(this char c)
		{
			return Char.IsLetter(c);
		}

		public static bool IsLetterOrDigit(this char c)
		{
			return Char.IsLetterOrDigit(c);
		}

		public static bool IsLower(this char c)
		{
			return Char.IsLower(c);
		}

		public static bool IsNumber(this char c)
		{
			return Char.IsNumber(c);
		}

		public static bool IsUpper(this char c)
		{
			return Char.IsUpper(c);
		}

		public static bool IsWhiteSpace(this char c)
		{
			return Char.IsWhiteSpace(c);
		}
	}
}