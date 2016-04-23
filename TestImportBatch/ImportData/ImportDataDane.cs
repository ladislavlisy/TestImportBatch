using System;

namespace TestImportBatch
{
	public class ImportDataDane
	{
		public string OsobCislo { get; set; }
		public string DanePodep { get; set; }
		public string DaneInv01 { get; set; }
		public string DaneInv02 { get; set; }
		public string DaneInv03 { get; set; }
		public ImportDataDane()
		{
			OsobCislo = "0001";
			DanePodep = "";
			DaneInv01 = "";
			DaneInv02 = "";
			DaneInv03 = "";
		}
	}
}

