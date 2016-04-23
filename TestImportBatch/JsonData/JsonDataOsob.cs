using System;

namespace TestImportBatch
{
	public class JsonDataOsob
	{
		public string Prijmeni { get; set; }
		public string Jmeno { get; set; }
		public string TitulPred { get; set; }
		public string TitulZa { get; set; }
		public string RodneCislo { get; set; }
		public JsonDataOsob()
		{
			Prijmeni = "Pracovnik";
			Jmeno = "Test";
			TitulPred = "";
			TitulZa = "";
			RodneCislo = "7707077070";
		}
	}
}

