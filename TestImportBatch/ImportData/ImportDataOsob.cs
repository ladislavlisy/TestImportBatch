using System;

namespace TestImportBatch
{
	public class ImportDataOsob
	{
		public string PracPrijm { get; set; }
		public string PracJmeno { get; set; }
		public string PracTitul { get; set; }
		public string PracTitZa { get; set; }
		public string PracRodne { get; set; }
		public ImportDataOsob()
		{
			PracPrijm = "Pracovnik";
			PracJmeno = "Test";
			PracTitul = "";
			PracTitZa = "";
			PracRodne = "7707077070";
		}
	}
}

