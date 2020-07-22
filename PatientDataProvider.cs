using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
	class PatientDataProvider
	{
		List<PatientData> patientDataList;
		public void PatientDataListProvider()
		{
			PatientDataListProvider ptDataListProvider = new PatientDataListProvider();
			patientDataList = ptDataListProvider.GetPatientList();
		}

		public List<PatientData> GetPatientsByNameAndAge()
		{
			CompositeFilter compositeFilter = new CompositeFilter();
			NameFilter nameFilter = new NameFilter("abc");
			compositeFilter.AddFilter(nameFilter);
			AgeFilter ageFilter = new AgeFilter(25);
			compositeFilter.AddFilter(ageFilter);

			return compositeFilter.Filter(patientDataList);
		}

		public List<PatientData> GetPatientsByName()
		{
			NameFilter nameFilter = new NameFilter("abc");
			return nameFilter.Filter(patientDataList);
		}

		public List<PatientData> GetPatientsByAge()
		{
			AgeFilter ageFilter = new AgeFilter(25);
			return ageFilter.Filter(patientDataList);
		}
	}
}
