using System;
using NetExtensions.Internal;

namespace NetExtensions.Actions
{
	public static class TryExecuteExtensions
	{
		public static bool TryExecute(this Action action)
		{
			Ensure.IsNotNull(action, nameof(action));

			try
			{
				action();
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}