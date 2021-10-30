using System.Diagnostics.CodeAnalysis;

namespace System
{
	public static class NullableToPointer
	{
		[return: NotNullIfNotNull("value")]
		public static unsafe T* ToPointer<T>(this T? value) where T : unmanaged
		{
			T value_notnull = value!.Value;
			return value.HasValue ? &value_notnull : null;
		}
	}
}
