using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.builderPattern
{
	class CiviEngineer
	{
		private IHouseBuilder _builder;
		public CiviEngineer(IHouseBuilder builder) {
			_builder = builder;
		}

		public void GetHouse()
		{
			House house =_builder.BuildBasement()
								.BuildRoof()
								.GetHouse();
		}
	}
}
