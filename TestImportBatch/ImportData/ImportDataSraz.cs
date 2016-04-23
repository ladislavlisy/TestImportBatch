using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataSraz
	{
		public string RokMesPoc { get; set; }
		public string OsobCislo { get; set; }
		public string SrazSlKod { get; set; }
		public string ExecInKod { get; set; }
		public string SrazSazba { get; set; }
		public string SrazMinul { get; set; }
		public string SrazTrval { get; set; }
		public string SPoznamka { get; set; }
		public string ExecDatum { get; set; }
		public string VypZpusob { get; set; }
		public string VypBkUcet { get; set; }
		public string VypBkBank { get; set; }
		public string VypBkKSym { get; set; }
		public string VypBkVSym { get; set; }
		public string VypBkSSym { get; set; }
		public ImportDataSraz()
		{
			RokMesPoc = "";
			OsobCislo = "";
			SrazSlKod = "";
			ExecInKod = "";
			SrazSazba = "";
			SrazMinul = "";
			SrazTrval = "";
			SPoznamka = "";
			ExecDatum = "";
			VypZpusob = "";
			VypBkUcet = "";
			VypBkBank = "";
			VypBkKSym = "";
			VypBkVSym = "";
			VypBkSSym = "";
		}

		public void ExportDataImp21(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(21);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, SrazSlKod);///IMP21_KODSRAZ 
			ImportUtils.AppendEmpty(builder);//IMP21_KODSRAZTEXT 
			ImportUtils.AppendField(builder, SrazMinul);//IMP21_CELKEM 
			ImportUtils.AppendEmpty(builder);//IMP21_MESICNI 
			ImportUtils.AppendEmpty(builder);//IMP21_PROCJED 
			ImportUtils.AppendField(builder, SrazSazba);//IMP21_POSLEDNI 
			ImportUtils.AppendField(builder, ExecInKod);//IMP21_POSLEDNIDEN 
			ImportUtils.AppendEmpty(builder);//IMP21_POSLEDNIMES 
			ImportUtils.AppendEmpty(builder);//IMP21_POSLEDNIROK 
			ImportUtils.AppendEmpty(builder);//IMP21_STRED 
			ImportUtils.AppendEmpty(builder);//IMP21_CINN 
			ImportUtils.AppendEmpty(builder);//IMP21_ZAK 
			ImportUtils.AppendField(builder, SrazTrval);//IMP21_TRVALE 
			ImportUtils.AppendField(builder, VypZpusob);//IMP02_ZPUSOB
			ImportUtils.AppendEmpty(builder);//IMP02_OBEC
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_COBEC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DTYP 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_ULICE 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_PSC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_POSTA 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_OCIS 
			ImportUtils.AppendField(builder, VypBkUcet);//IMP_BKSPOJ_UCET 
			ImportUtils.AppendField(builder, VypBkBank);//IMP_BKSPOJ_USTAV 
			ImportUtils.AppendField(builder, VypBkKSym);//IMP_BKSPOJ_KSYMB 
			ImportUtils.AppendField(builder, VypBkVSym);//IMP_BKSPOJ_VSYMB 
			ImportUtils.AppendField(builder, VypBkSSym);//IMP_BKSPOJ_SSYMB 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_MENA 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_ZEME 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_MESTO 
			ImportUtils.AppendEmpty(builder);//IMP21_SRAZJENPLNA 
			ImportUtils.AppendField(builder, ExecDatOd());//IMP21_POSLEDNI 
			ImportUtils.AppendField(builder, SPoznamka);//IMP21_POSLEDNI 

			writer.WriteLine(builder.ToString());
		}
		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesPoc);
		}
		public long RokPocitany()
		{
			return UtilsTable.RokNumber(RokMesPoc);
		}
		public long MesPocitany()
		{
			return UtilsTable.MesNumber(RokMesPoc);
		}

		public string ExecDatOd()
		{
			DateTime? exec_datum_dor = UtilsTable.DatumTecky(ExecDatum);

			if (!exec_datum_dor.HasValue)
			{
				return "";
			}
			return exec_datum_dor.Value.ToString("dd.MM.yyyy");
		}
	}
}

