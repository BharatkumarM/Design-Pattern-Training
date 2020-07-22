using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class NameFilter : ISearchFilter
	{
		private string name;
		public NameFilter(string name)
		{
			this.name = name;
		}

		public List<PatientData> Filter(List<PatientData> ptDataList)
		{
			//filtering
			return new List<PatientData>();
		}
	}
}
