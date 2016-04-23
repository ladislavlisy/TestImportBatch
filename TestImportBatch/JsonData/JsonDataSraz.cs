using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataSraz
	{
		public string RokMesicZaznamu { get; set; }
		public string OsobniCislo { get; set; }
		public string SlozkaKod { get; set; }
		public string ExekuceKod { get; set; }
		public string CastkaSazba { get; set; }
		public string CastkaMinule { get; set; }
		public string StalostTrvale { get; set; }
		public string SrazkaPoznamka { get; set; }
		public string ExekuceDatum { get; set; }
		public string ZpusobVyplaty { get; set; }
		public string BankovniUcet { get; set; }
		public string BankovniUstav { get; set; }
		public string KonstantniSymbol { get; set; }
		public string VariabilniSymbol { get; set; }
		public string SpecifickySymbol { get; set; }
		public JsonDataSraz()
		{
			RokMesicZaznamu = "";
			OsobniCislo = "";
			SlozkaKod = "";
			ExekuceKod = "";
			CastkaSazba = "";
			CastkaMinule = "";
			StalostTrvale = "";
			SrazkaPoznamka = "";
			ExekuceDatum = "";
			ZpusobVyplaty = "";
			BankovniUcet = "";
			BankovniUstav = "";
			KonstantniSymbol = "";
			VariabilniSymbol = "";
			SpecifickySymbol = "";
		}

		public void ExportDataImp21(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(21);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, SlozkaKod);///IMP21_KODSRAZ 
			ImportUtils.AppendEmpty(builder);//IMP21_KODSRAZTEXT 
			ImportUtils.AppendField(builder, CastkaMinule);//IMP21_CELKEM 
			ImportUtils.AppendEmpty(builder);//IMP21_MESICNI 
			ImportUtils.AppendEmpty(builder);//IMP21_PROCJED 
			ImportUtils.AppendField(builder, CastkaSazba);//IMP21_POSLEDNI 
			ImportUtils.AppendField(builder, ExekuceKod);//IMP21_POSLEDNIDEN 
			ImportUtils.AppendEmpty(builder);//IMP21_POSLEDNIMES 
			ImportUtils.AppendEmpty(builder);//IMP21_POSLEDNIROK 
			ImportUtils.AppendEmpty(builder);//IMP21_STRED 
			ImportUtils.AppendEmpty(builder);//IMP21_CINN 
			ImportUtils.AppendEmpty(builder);//IMP21_ZAK 
			ImportUtils.AppendField(builder, StalostTrvale);//IMP21_TRVALE 
			ImportUtils.AppendField(builder, ZpusobVyplaty);//IMP02_ZPUSOB
			ImportUtils.AppendEmpty(builder);//IMP02_OBEC
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_COBEC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DTYP 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_ULICE 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_PSC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_POSTA 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_OCIS 
			ImportUtils.AppendField(builder, BankovniUcet);//IMP_BKSPOJ_UCET 
			ImportUtils.AppendField(builder, BankovniUstav);//IMP_BKSPOJ_USTAV 
			ImportUtils.AppendField(builder, KonstantniSymbol);//IMP_BKSPOJ_KSYMB 
			ImportUtils.AppendField(builder, VariabilniSymbol);//IMP_BKSPOJ_VSYMB 
			ImportUtils.AppendField(builder, SpecifickySymbol);//IMP_BKSPOJ_SSYMB 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_MENA 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_ZEME 
			ImportUtils.AppendEmpty(builder);//IMP21_OPT_MESTO 
			ImportUtils.AppendEmpty(builder);//IMP21_SRAZJENPLNA 
			ImportUtils.AppendField(builder, ExecDatOd());//IMP21_POSLEDNI 
			ImportUtils.AppendField(builder, SrazkaPoznamka);//IMP21_POSLEDNI 

			writer.WriteLine(builder.ToString());
		}
		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesicZaznamu);
		}
		public long RokPocitany()
		{
			return UtilsTable.RokNumber(RokMesicZaznamu);
		}
		public long MesPocitany()
		{
			return UtilsTable.MesNumber(RokMesicZaznamu);
		}

		public string ExecDatOd()
		{
			DateTime? exec_datum_dor = UtilsTable.DatumTecky(ExekuceDatum);

			if (!exec_datum_dor.HasValue)
			{
				return "";
			}
			return exec_datum_dor.Value.ToString("dd.MM.yyyy");
		}
	}
}

