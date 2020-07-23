using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class AgeFilter : ISearchFilter
	{
		private int _age;
		public AgeFilter(int age)
		{
			this._age = age;
		}
		public List<PatientData> Filter(List<PatientData> ptDataList)
		{
			//filtering
			return new List<PatientData>();
		}
	}
}
