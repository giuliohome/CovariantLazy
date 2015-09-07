
using System;

namespace LazyTest
{
	/// <summary>
	/// Description of CovLazy.
	/// </summary>
	public class CovLazy<T> : ILazy<T>
	{
		private Lazy<T> myBase;
		public CovLazy()
		{
			myBase = new Lazy<T>();
		}
		public T MyVal {
			get {
				return myBase.Value; 
			}
		}
	}
}
