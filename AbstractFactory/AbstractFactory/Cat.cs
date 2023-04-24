using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	abstract public class Cat : AnimalToy
	{
		protected Cat(string material) : base(material) { }
	}

	public class WoodenCat : Cat
	{
		public WoodenCat() : base("wood") { }
	}

	public class TeddyCat : Cat
	{
		public TeddyCat() : base("plush") { }
	}
}
