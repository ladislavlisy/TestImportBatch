using System;

namespace TestImportBatch
{
	public class ImportDataPers
	{
		public string OsobCislo { get; set; }
		public string PersVzdel { get; set; }
		public string PersOborV { get; set; }
		public string PersRidic { get; set; }
		public string PersTelC1 { get; set; }
		public string PersTelT1 { get; set; }
		public string PersTelC2 { get; set; }
		public string PersTelT2 { get; set; }
		public string PersVojak { get; set; }
		public string PPoznamka { get; set; }
		public ImportDataPers()
		{
			OsobCislo = "0001";
			PersVzdel = "";
			PersOborV = "";
			PersRidic = "";
			PersTelC1 = "";
			PersTelT1 = "";
			PersTelC2 = "";
			PersTelT2 = "";
			PersVojak = "";
			PPoznamka = "";
		}
	}
}

