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

		public List<PatientData> GetPatientByName()
		{
			NameFilter nameFilter = new NameFilter("abc");
			return nameFilter.Filter(patientDataList);
		}

		public List<PatientData> GetPatientByAge()
		{
			AgeFilter ageFilter = new AgeFilter(25);
			return ageFilter.Filter(patientDataList);
		}
	}
}
