# CovariantLazy

Covariant Lazy generic interface and its implementation, 

from http://stackoverflow.com/a/21117657

**Note** - as of Sep 8, 2015

A basic implementation of the `ILazy<out T>` interface can be found here. 
If you follow the *alternative* approach of a generic declaration with *constraints*, please notice that you won't be able to override a more specific method with subclass parameter: of course it would be possible to test the type

		public void lazyfeed(Lazy<Cat> c) //no covariance here
		{
			Console.WriteLine("Specific feed: "+ c.ToString());
		}
		public void lazyfeed<T>(Lazy<T> a) where T : Animal
		{
			if (a.GetType() == typeof(Lazy<SubCat>) ) { // but value is created

but at that point the class gets instantiated (immediately losing laziness), while the interface implementation is more powerful and flexible (like Servy's suggestion)

	public void covlazyfeed(ILazy<Animal> a) 
	{
		Console.WriteLine("Generic feed: "+ a.ToString());
	}
	public void covlazyfeed(ILazy<Cat> c)
	{
		Console.WriteLine("Specific feed: "+ c.ToString());
	}
