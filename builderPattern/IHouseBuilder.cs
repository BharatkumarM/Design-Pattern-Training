using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.builderPattern
{
	interface IHouseBuilder
	{
		IHouseBuilder BuildBasement();

		IHouseBuilder BuildRoof();

		House GetHouse();

	}
}
