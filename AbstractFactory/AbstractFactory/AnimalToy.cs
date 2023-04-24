using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	abstract public class AnimalToy
	{
		public string Material { get; protected set; }

		protected AnimalToy(string material) { Material = material; }
	}
}
