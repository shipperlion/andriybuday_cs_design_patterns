using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
	public interface IToyFactory
	{
		Bear GetBear();
		Cat GetCat();
	}
}
