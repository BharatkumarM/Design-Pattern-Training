using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	interface ISearchFilter
	{
		List<PatientData> Filter(List<PatientData> ptData);
	}
}
