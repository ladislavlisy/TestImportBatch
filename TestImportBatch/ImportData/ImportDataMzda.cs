using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataMzda
	{
		public string RokMesPoc { get; set; }
		public string RokMesZad { get; set; }
		public string OsobCislo { get; set; }
		public string PPomCislo { get; set; }
		public string MzdaSlKod { get; set; }
		public string MzdaSazba { get; set; }
		public string MzdaTrval { get; set; }
		public ImportDataMzda()
		{
			RokMesPoc = "";
			RokMesZad = "";
			OsobCislo = "0001";
			PPomCislo = "";
			MzdaSlKod = "";
			MzdaSazba = "";
			MzdaTrval = "";
		}
		public void CreateImportRecord19(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(19);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomCislo);///IMP17_PPOMER 
			ImportUtils.AppendField(builder, MzdaSlKod);///IMP19_KODMZDA
			ImportUtils.AppendEmpty(builder);//IMP19_KODMZDATEXT
			ImportUtils.AppendEmpty(builder);//IMP19_MINUTY
			ImportUtils.AppendEmpty(builder);//IMP19_MINUTYNORM
			ImportUtils.AppendEmpty(builder);//IMP19_JEDNOTKY
			ImportUtils.AppendField(builder, MzdaSazba100K());//IMP19_SAZBAKC
			ImportUtils.AppendEmpty(builder);//IMP19_SAZBAPROC
			ImportUtils.AppendEmpty(builder);//IMP19_STRED
			ImportUtils.AppendEmpty(builder);//IMP19_CINN
			ImportUtils.AppendEmpty(builder);//IMP19_ZAK
			ImportUtils.AppendField(builder, MzdaTrval);//IMP19_TRVALE
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
			long nDataNumb = UtilsTable.Int32ParseNumber(MzdaSazba);
			return (nDataNumb * 100);
		}
	}
}

