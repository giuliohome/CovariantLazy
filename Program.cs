
using System;

namespace LazyTest
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			// TODO: Implement Functionality Here
			
			Animal a = new Animal();
			Cat c = new Cat();
			Dog d = new Dog();
			Covariance cov = new Covariance();
			
			Console.WriteLine("---------------- Test generic animal");
			a.Out();
			cov.feed(a);
			Console.WriteLine("---------------- Func now");
			cov.funcfeed(() => a);
			Console.WriteLine("---------------- and Lazy!");
			var l_a = new Lazy<Animal>();
			cov.lazyfeed(l_a);
			Console.WriteLine("created {0}",l_a.IsValueCreated);
			Console.WriteLine("---------------- Func+Lazy");
			cov.funcfeed(() => l_a.Value);
			Console.WriteLine("created {0}",l_a.IsValueCreated);
			l_a.Value.Out();
			Console.WriteLine("---------------- CovLazy!!");
			var cl_a = new CovLazy<Animal>();
			cov.covlazyfeed(cl_a);
			Console.WriteLine("fired {0}",cl_a.IsFired);
			cl_a.MyVal.Out();
			Console.WriteLine("---------------- Test cat");
			c.Out();
			cov.feed(c);
			Console.WriteLine("---------------- Func now");
			cov.funcfeed(() => c);
			Console.WriteLine("---------------- and Lazy!");
			var l_c = new Lazy<Cat>();
			cov.lazyfeed(l_c);
			Console.WriteLine("created {0}",l_c.IsValueCreated);
			Console.WriteLine("---------------- Func+Lazy");
			cov.funcfeed(() => l_c.Value);
			Console.WriteLine("created {0}",l_c.IsValueCreated);
			l_c.Value.Out();
			Console.WriteLine("---------------- CovLazy!!");
			var cl_c = new CovLazy<Cat>();
			cov.covlazyfeed(cl_c);
			Console.WriteLine("fired {0}",cl_c.IsFired);
			cl_c.MyVal.Out();
			Console.WriteLine("---------------- Test dog");
			d.Out();
			cov.feed(new Dog());
			Console.WriteLine("---------------- Func now");
			cov.funcfeed(() => d);
			Console.WriteLine("---------------- and Lazy!");
			var l_d = new Lazy<Dog>();
			cov.lazyfeed(l_d);
			Console.WriteLine("created {0}",l_d.IsValueCreated);
			Console.WriteLine("---------------- Func+Lazy");
			cov.funcfeed(() => l_d.Value);
			Console.WriteLine("created {0}",l_d.IsValueCreated);
			l_d.Value.Out();
			Console.WriteLine("---------------- CovLazy!!");
			var cl_d = new CovLazy<Dog>();
			cov.covlazyfeed(cl_d);
			Console.WriteLine("fired {0}",cl_d.IsFired);
			cl_d.MyVal.Out();
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}