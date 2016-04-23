using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataNepr
	{
		public string RokMesicZaznamu { get; set; }
		public string OsobniCislo { get; set; }
		public string PPomerCislo { get; set; }
		public string SlozkaKod { get; set; }
		public string DatumZacatek { get; set; }
		public string DatumKonec { get; set; }
		public JsonDataNepr()
		{
			RokMesicZaznamu = "";
			OsobniCislo = "";
			PPomerCislo = "";
			SlozkaKod = "";
			DatumZacatek = "";
			DatumKonec = "";
		}

		public void ExportDataImp20(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(20);

			DateTime? nepr_datum_zac = UtilsTable.DatumTecky(DatumZacatek);
			DateTime? nepr_datum_kon = UtilsTable.DatumTecky(DatumKonec);

			if (!nepr_datum_kon.HasValue)
			{
				nepr_datum_kon = new DateTime((int)RokPocitany(), 12, 31);
			}

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomerCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, SlozkaKod);//IMP20_KODNEPR
			ImportUtils.AppendEmpty(builder);//IMP20_KODNEPRTEXT
			ImportUtils.AppendField(builder, nepr_datum_zac.Value.ToString("dd.MM.yyyy"));//IMP20_DATUMZAC
			ImportUtils.AppendField(builder, nepr_datum_kon.Value.ToString("dd.MM.yyyy"));//IMP20_DATUMKON
			ImportUtils.AppendEmpty(builder);//IMP20_PRVNIDEN
			ImportUtils.AppendEmpty(builder);//IMP20_POSLEDEN
			ImportUtils.AppendEmpty(builder);//IMP20_SAZBAKC
			ImportUtils.AppendEmpty(builder);//IMP20_SAZBAPROC
			ImportUtils.AppendEmpty(builder);//IMP20_ZAPVYD
			//IMP20_DOKLAD
			ImportUtils.AppendEmpty(builder);//IMP20_PLATIT
			ImportUtils.AppendEmpty(builder);//IMP20_STRED
			ImportUtils.AppendEmpty(builder);//IMP20_CINN
			ImportUtils.AppendEmpty(builder);//IMP20_ZAK
			ImportUtils.AppendEmpty(builder);//IMP20_TRVALE

			writer.WriteLine(builder.ToString());
		}

		public void ExportDataImp44(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(44);

			DateTime? nepr_datum_zac = UtilsTable.DatumTecky(DatumZacatek);
			DateTime? nepr_datum_kon = UtilsTable.DatumTecky(DatumKonec);

			if (!nepr_datum_kon.HasValue)
			{
				nepr_datum_kon = new DateTime((int)RokPocitany(), 12, 31);
			}
			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO              
			ImportUtils.AppendField(builder, PPomerCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, SlozkaKod);//const int IMP44_KODNEPR = 4;
			ImportUtils.AppendEmpty(builder);//const int IMP44_KODNEPRTEXT = 5;
			ImportUtils.AppendField(builder, nepr_datum_zac.Value.ToString("dd.MM.yyyy"));//const int IMP44_DATUMZAC = 6;
			ImportUtils.AppendField(builder, nepr_datum_kon.Value.ToString("dd.MM.yyyy"));//const int IMP44_DATUMKON = 7;
			ImportUtils.AppendField(builder, UtilsTable.DatumPocetDnu(nepr_datum_zac, nepr_datum_kon));//const int IMP44_POCETDNU = 8;
			ImportUtils.AppendEmpty(builder);//const int IMP44_VYLOUCENA = 9;
			ImportUtils.AppendEmpty(builder);//const int IMP44_DOKLAD = 10;
			ImportUtils.AppendEmpty(builder);//const int IMP44_NAZEVZAM = 11;
			ImportUtils.AppendEmpty(builder);//const int IMP44_ICZAM = 12;
			ImportUtils.AppendEmpty(builder);//const int IMP44_DATPOROD = 13;
			ImportUtils.AppendEmpty(builder);//const int IMP44_HODNOTAKC = 14;

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

	}
}

