using System;

namespace TestImportBatch
{
	public class JsonDataBank
	{
		public string BankovniUcet { get; set; }
		public string BankovniUstav { get; set; }
		public string KonstantniSymbol { get; set; }
		public string VariabilniSymbol { get; set; }
		public string SpecifickySymbol { get; set; }
		public JsonDataBank()
		{
			BankovniUcet = "";
			BankovniUstav = "";
			KonstantniSymbol = "";
			VariabilniSymbol = "";
			SpecifickySymbol = "";
		}
	}
}

