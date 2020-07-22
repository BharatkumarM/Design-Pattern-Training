using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class AgeFilter : ISearchFilter
	{
		private int age;
		public AgeFilter(int age)
		{
			this.age = age;
		}
		public List<PatientData> Filter(List<PatientData> ptDataList)
		{
			//filtering
			return new List<PatientData>();
		}
	}
}
