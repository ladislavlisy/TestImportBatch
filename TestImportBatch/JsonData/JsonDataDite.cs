using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataDite
	{
		public string RokMesicZaznamu { get; set; }
		public string OsobniCislo { get; set; }
		public string RokProhlaseni { get; set; }
		public string Prijmeni { get; set; }
		public string Jmeno { get; set; }
		public string TitulPred { get; set; }
		public string TitulZa { get; set; }
		public string RodneCislo { get; set; }
		public string RokMesicUkonecni { get; set; }
		public string UplatnovanaSleva { get; set; }
		public string AktualniMesicSleva { get; set; }
		public string UplatnovanePoradi { get; set; }
		public string AktualniMesicPoradi { get; set; }
		public string DiteJeZTP { get; set; }

		public JsonDataDite()
		{
			RokMesicZaznamu = "";
			OsobniCislo = "0001";
			Prijmeni = "Pracovnik";
			Jmeno = "Dite";
			TitulPred = "";
			TitulZa = "";
			RodneCislo = "0505055050";
			RokProhlaseni = "";
			RokMesicUkonecni = "";
			UplatnovanaSleva = "";
			AktualniMesicSleva = "";
			UplatnovanePoradi = "";
			AktualniMesicPoradi = "";
			DiteJeZTP = "";
		}
		public void CreateImportRecord09(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(9);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, RokProhlaseni);//IMP00_PRIJMYROK
			ImportUtils.AppendField(builder, RodneCislo);//IMP09_RODCIS 
			ImportUtils.AppendField(builder, Prijmeni);//IMP09_PRIJ 
			ImportUtils.AppendField(builder, Jmeno);//IMP09_JMENO 
			ImportUtils.AppendField(builder, TitulPred);//IMP09_TITULPRED 
			ImportUtils.AppendField(builder, TitulZa);//IMP09_TITULZA 
			ImportUtils.AppendField(builder, DiteJeZTP);//IMP09_ZTPP 
			ImportUtils.AppendField(builder, MesKonNumber());//IMP09_KONUPLATMES 
			ImportUtils.AppendField(builder, RokKonNumber());//IMP09_KONUPLATROK 
			ImportUtils.AppendField(builder, UplatnovanaSleva);//IMP09_PLATNOSTOBD 
			ImportUtils.AppendField(builder, AktualniMesicSleva);//IMP09_AKTUALNIOBD 
			ImportUtils.AppendField(builder, UplatnovanePoradi);//IMP09_PORADIOBD 
			ImportUtils.AppendField(builder, AktualniMesicPoradi);//IMP09_AKTUALNIPOR 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public long MesKonNumber()
		{
			return UtilsTable.MesNumber(RokMesicUkonecni);
		}
		public long RokKonNumber()
		{
			return UtilsTable.RokNumber(RokMesicUkonecni);
		}
	}
}

