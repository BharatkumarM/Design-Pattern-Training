using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class CompositeFilter : ISearchFilter
	{
		List<ISearchFilter> filters;

		public void AddFilter(ISearchFilter filter)
		{
			filters.Add(filter);
		}

		public void RemoveFilter(ISearchFilter filter)
		{
			filters.Remove(filter);
		}

		public List<PatientData> Filter(List<PatientData> ptData)
		{
			List<PatientData> patients = new List<PatientData>();
			filters.ForEach((filter) =>
			{
				List<PatientData> patientList = filter.Filter(ptData);
				patients.AddRange(patientList);
			});
			return patients;
		}
	}
}
