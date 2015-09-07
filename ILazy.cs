
using System;

namespace LazyTest
{
	/// <summary>
	/// Description of ILazy.
	/// </summary>
	public interface ILazy<out T>
	{
		T MyVal { get; }
	}
}
