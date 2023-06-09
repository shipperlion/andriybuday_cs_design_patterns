﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	abstract public class Bear : AnimalToy
	{
		protected Bear(string material) : base(material) { }
	}

	public class WoodenBear : Bear
	{
		public WoodenBear() : base("wood") { }
	}

	public class TeddyBear : Bear
	{
		public TeddyBear() : base("plush") { }
	}
}
