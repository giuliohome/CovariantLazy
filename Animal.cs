/*
 * Created by SharpDevelop.
 * User: en21165
 * Date: 07/09/2015
 * Time: 15:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace LazyTest
{
	/// <summary>
	/// Description of Animal.
	/// </summary>
	public class Animal
	{
		public Animal()
		{
			Console.WriteLine("Slow constructor");
		}
		public void Out()
		{
			Console.WriteLine(this.GetType().FullName);
		}
	}
}
