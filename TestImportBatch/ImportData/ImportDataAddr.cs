using System;

namespace TestImportBatch
{
	public class ImportDataAddr
	{
		public string AdrTUlice { get; set; }
		public string AdrTMesto { get; set; }
		public string AdrTOCast { get; set; }
		public string AdrTPosta { get; set; }
		public string AdrTDomCs { get; set; }
		public string AdrTDomDr { get; set; }
		public string AdrTOriCs { get; set; }
		public string AdrTPscCs { get; set; }
		public string AdrTStatK { get; set; }
		public ImportDataAddr()
		{
			AdrTUlice = "Zvoncovitá";
			AdrTMesto = "Praha";
			AdrTOCast = "";
			AdrTPosta = "Praha 1";
			AdrTDomCs = "1/7";
			AdrTDomDr = "1";
			AdrTPscCs = "15500";
			AdrTStatK = "CR";
		}
	}
}

