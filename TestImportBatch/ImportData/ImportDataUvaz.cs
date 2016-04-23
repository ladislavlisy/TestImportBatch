using System;

namespace TestImportBatch
{
	public class ImportDataUvaz
	{
		public string OsobCislo { get; set; }
		public string PPomCislo { get; set; }
		public string PPomOdmen { get; set; }
		public string PPomDUvaz { get; set; }
		public string PPomPlnyU { get; set; }
		public string PPomSkutU { get; set; }
		public ImportDataUvaz()
		{
			OsobCislo = "0001";
			PPomCislo = "";
			PPomOdmen = "";
			PPomDUvaz = "";
			PPomPlnyU = "";
			PPomSkutU = "";
		}

		internal long PPomPlnyUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PPomPlnyU);
			return (nDataNumb * 60);
		}

		internal long PPomSkutUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PPomSkutU);
			return (nDataNumb * 60);
		}
	}
}

