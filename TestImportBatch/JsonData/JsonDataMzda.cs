using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataMzda
	{
		public string RokMesicZaznamu { get; set; }
		public string RokMesicZadani { get; set; }
		public string OsobniCislo { get; set; }
		public string PPomerCislo { get; set; }
		public string SlozkaKod { get; set; }
		public string CastkaSazba { get; set; }
		public string StalostTrvale { get; set; }
		public JsonDataMzda()
		{
			RokMesicZaznamu = "";
			RokMesicZadani = "";
			OsobniCislo = "0001";
			PPomerCislo = "";
			SlozkaKod = "";
			CastkaSazba = "";
			StalostTrvale = "";
		}
		public void CreateImportRecord19(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(19);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomerCislo);///IMP17_PPOMER 
			ImportUtils.AppendField(builder, SlozkaKod);///IMP19_KODMZDA
			ImportUtils.AppendEmpty(builder);//IMP19_KODMZDATEXT
			ImportUtils.AppendEmpty(builder);//IMP19_MINUTY
			ImportUtils.AppendEmpty(builder);//IMP19_MINUTYNORM
			ImportUtils.AppendEmpty(builder);//IMP19_JEDNOTKY
			ImportUtils.AppendField(builder, MzdaSazba100K());//IMP19_SAZBAKC
			ImportUtils.AppendEmpty(builder);//IMP19_SAZBAPROC
			ImportUtils.AppendEmpty(builder);//IMP19_STRED
			ImportUtils.AppendEmpty(builder);//IMP19_CINN
			ImportUtils.AppendEmpty(builder);//IMP19_ZAK
			ImportUtils.AppendField(builder, StalostTrvale);//IMP19_TRVALE
			ImportUtils.AppendEmpty(builder);//IMP19_OPT_TARIF
			ImportUtils.AppendEmpty(builder);//IMP19_OPT_TSTUP
			ImportUtils.AppendEmpty(builder);//IMP19_OPT_TAUTO
			ImportUtils.AppendEmpty(builder);//IMP19_OPT_ZDROJ
			ImportUtils.AppendEmpty(builder);//IMP19_VALUTA_KOD

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		private long MzdaSazba100K()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(CastkaSazba);
			return (nDataNumb * 100);
		}
	}
}

