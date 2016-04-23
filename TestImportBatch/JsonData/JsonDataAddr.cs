using System;

namespace TestImportBatch
{
	public class JsonDataAddr
	{
		public string Ulice { get; set; }
		public string Mesto { get; set; }
		public string CastObce { get; set; }
		public string Posta { get; set; }
		public string DomovniCislo { get; set; }
		public string DomovniCisloTyp { get; set; }
		public string OrientacniCislo { get; set; }
		public string PscCislo { get; set; }
		public string StatAdresy { get; set; }
		public JsonDataAddr()
		{
			Ulice = "Zvoncovitá";
			Mesto = "Praha";
			CastObce = "";
			Posta = "Praha 1";
			DomovniCislo = "1/7";
			DomovniCisloTyp = "1";
			PscCislo = "15500";
			StatAdresy = "CR";
		}
	}
}

