using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataDite
	{
		public string RokMesPoc { get; set; }
		public string OsobCislo { get; set; }
		public string ProhObdob { get; set; }
		public string DitePrijm { get; set; }
		public string DiteJmeno { get; set; }
		public string DiteTitul { get; set; }
		public string DiteTitZa { get; set; }
		public string DiteRodne { get; set; }
		public string RokMesKon { get; set; }
		public string UplRSleva { get; set; }
		public string AktMSleva { get; set; }
		public string UplPoradi { get; set; }
		public string AktPoradi { get; set; }
		public string DiteJeZTP { get; set; }

		public ImportDataDite()
		{
			RokMesPoc = "";
			OsobCislo = "0001";
			DitePrijm = "Pracovnik";
			DiteJmeno = "Dite";
			DiteTitul = "";
			DiteTitZa = "";
			DiteRodne = "0505055050";
			ProhObdob = "";
			RokMesKon = "";
			UplRSleva = "";
			AktMSleva = "";
			UplPoradi = "";
			AktPoradi = "";
			DiteJeZTP = "";
		}
		public void CreateImportRecord09(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(9);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, ProhObdob);//IMP00_PRIJMYROK
			ImportUtils.AppendField(builder, DiteRodne);//IMP09_RODCIS 
			ImportUtils.AppendField(builder, DitePrijm);//IMP09_PRIJ 
			ImportUtils.AppendField(builder, DiteJmeno);//IMP09_JMENO 
			ImportUtils.AppendField(builder, DiteTitul);//IMP09_TITULPRED 
			ImportUtils.AppendField(builder, DiteTitZa);//IMP09_TITULZA 
			ImportUtils.AppendField(builder, DiteJeZTP);//IMP09_ZTPP 
			ImportUtils.AppendField(builder, MesKonNumber());//IMP09_KONUPLATMES 
			ImportUtils.AppendField(builder, RokKonNumber());//IMP09_KONUPLATROK 
			ImportUtils.AppendField(builder, UplRSleva);//IMP09_PLATNOSTOBD 
			ImportUtils.AppendField(builder, AktMSleva);//IMP09_AKTUALNIOBD 
			ImportUtils.AppendField(builder, UplPoradi);//IMP09_PORADIOBD 
			ImportUtils.AppendField(builder, AktPoradi);//IMP09_AKTUALNIPOR 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public long MesKonNumber()
		{
			return UtilsTable.MesNumber(RokMesKon);
		}
		public long RokKonNumber()
		{
			return UtilsTable.RokNumber(RokMesKon);
		}
	}
}

