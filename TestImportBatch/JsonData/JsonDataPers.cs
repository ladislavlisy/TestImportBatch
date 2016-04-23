using System;

namespace TestImportBatch
{
	public class JsonDataPers
	{
		public string OsobniCislo { get; set; }
		public string VzdelaniKod { get; set; }
		public string OborVzdelani { get; set; }
		public string RidicPrukaz { get; set; }
		public string TelefonCislo1 { get; set; }
		public string TelefonTyp1 { get; set; }
		public string TelefonCislo2 { get; set; }
		public string TelefonTyp2 { get; set; }
		public string VojakKod { get; set; }
		public string Poznamka { get; set; }
		public JsonDataPers()
		{
			OsobniCislo = "0001";
			VzdelaniKod = "";
			OborVzdelani = "";
			RidicPrukaz = "";
			TelefonCislo1 = "";
			TelefonTyp1 = "";
			TelefonCislo2 = "";
			TelefonTyp2 = "";
			VojakKod = "";
			Poznamka = "";
		}
	}
}

