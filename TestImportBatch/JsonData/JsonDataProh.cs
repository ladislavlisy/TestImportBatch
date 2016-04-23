using System;

namespace TestImportBatch
{
	public class JsonDataProh
	{
		public string OsobniCislo { get; set; }
		public string RokProhlaseni { get; set; }
		public string ObdobiPrijmu { get; set; }
		public string ObdobiPodepsal { get; set; }
		public string ObdobiInvalida1 { get; set; }
		public string ObdobiInvalida2 { get; set; }
		public string ObdobiInvalida3 { get; set; }
		public string ProvestZuctovani { get; set; }
		public string ZuctovanePrijmy { get; set; }
		public string ZuctovanePojistne { get; set; }
		public string ZuctovaneZalohy { get; set; }
		public string ZuctovaneSlevyPopl { get; set; }
		public string ZuctovaneSlevyDeti { get; set; }
		public string ZuctovaneBonusyDeti { get; set; }
		public string ZuctovanePrispevkyPenz { get; set; }
		public string ZuctovanePrispevkyZivot { get; set; }
		public JsonDataProh()
		{
			OsobniCislo = "0001";
			RokProhlaseni = "";
			ObdobiPrijmu = "";
			ObdobiPodepsal = "";
			ObdobiInvalida1 = "";
			ObdobiInvalida2 = "";
			ObdobiInvalida3 = "";
			ProvestZuctovani = "";
			ZuctovanePrijmy = "";
			ZuctovanePojistne = "";
			ZuctovaneZalohy = "";
			ZuctovaneSlevyPopl = "";
			ZuctovaneSlevyDeti = "";
			ZuctovaneBonusyDeti = "";
			ZuctovanePrispevkyPenz = "";
			ZuctovanePrispevkyZivot = "";
		}
	}
}

