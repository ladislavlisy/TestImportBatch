using System;

namespace TestImportBatch
{
	public class JsonDataDane
	{
		public string OsobniCislo { get; set; }
		public string MesicPodepsal { get; set; }
		public string MesicInvalida1 { get; set; }
		public string MesicInvalida2 { get; set; }
		public string MesicInvalida3 { get; set; }
		public JsonDataDane()
		{
			OsobniCislo = "0001";
			MesicPodepsal = "";
			MesicInvalida1 = "";
			MesicInvalida2 = "";
			MesicInvalida3 = "";
		}
	}
}

