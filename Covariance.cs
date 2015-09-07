
using System;

namespace LazyTest
{
	/// <summary>
	/// Description of Covariance.
	/// </summary>
	public class Covariance
	{
		public Covariance()
		{
		}
		
		public void feed(Animal a) {
			Console.WriteLine("Generic feed: "+ a.GetType().Name);
		}
		public void feed(Cat c) {
			Console.WriteLine("Specific feed: "+ c.GetType().Name);
		}
		
		public void funcfeed(Func<Animal> a) 
		{
			Console.WriteLine("Generic feed: "+ a.Invoke().GetType().Name);
		}
		public void funcfeed(Func<Cat> c) {
			Console.WriteLine("Specific feed: "+ c.Invoke().GetType().Name);
		}
		
		
		//Argument 1: cannot convert from 'System.Lazy<LazyTest.Dog>' to 'System.Lazy<LazyTest.Animal>' (CS1503) - C:\Dati\sharpdevelop projects\4\test\LazyTest\Program.cs:51,17
		public void lazyfeed(Lazy<Animal> a) // this is not covariant 
		{
			Console.WriteLine("Generic feed: "+ a.Value.GetType().Name);
		}
		public void lazyfeed<T>(Lazy<T> a) where T : Animal
		{
			if (a.GetType() == typeof(Lazy<Dog>) ) {
				Console.WriteLine("typeof Dog");
			} else {
				Console.WriteLine("typeof " + a.GetType().Name);
			}
			Console.WriteLine("generic declaration with contraints -> feed: "+ a.Value.GetType().Name);
		}
		public void lazyfeed(Lazy<Cat> c)
		{
			Console.WriteLine("Specific feed: "+ c.Value.GetType().Name);
		}
		
		public void covlazyfeed(ILazy<Animal> a) 
		{
			Console.WriteLine("Generic feed: "+ a.MyVal.GetType().Name);
		}
		public void covlazyfeed(ILazy<Cat> c)
		{
			Console.WriteLine("Specific feed: "+ c.MyVal.GetType().Name);
		}
	}
}
