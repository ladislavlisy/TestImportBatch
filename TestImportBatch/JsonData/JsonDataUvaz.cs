using System;

namespace TestImportBatch
{
	public class JsonDataUvaz
	{
		public string OsobniCislo { get; set; }
		public string PPomerCislo { get; set; }
		public string Odmenovani { get; set; }
		public string UvazekDruh { get; set; }
		public string PlnyUvazekHodin { get; set; }
		public string SkutecnyUvazekHodin { get; set; }
		public JsonDataUvaz()
		{
			OsobniCislo = "0001";
			PPomerCislo = "";
			Odmenovani = "";
			UvazekDruh = "";
			PlnyUvazekHodin = "";
			SkutecnyUvazekHodin = "";
		}

		internal long PPomPlnyUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PlnyUvazekHodin);
			return (nDataNumb * 60);
		}

		internal long PPomSkutUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(SkutecnyUvazekHodin);
			return (nDataNumb * 60);
		}
	}
}

