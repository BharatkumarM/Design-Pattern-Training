using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.builderPattern
{
	class HouseBuilder : IHouseBuilder
	{
		House house;
		public IHouseBuilder BuildBasement()
		{
			house.isBasementBuilt = true;
			return this;
		}

		public IHouseBuilder BuildRoof()
		{
			house.isRoofBuilt = true;
			return this;
		}

		public House GetHouse()
		{
			return house;
		}
	}
}
