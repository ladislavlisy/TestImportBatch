using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataUPom
	{
		public string RokMesicZaznamu { get; set; }
		public string OsobniCislo { get; set; }
		//public JsonDataPPom PPom { get; set; }
		public string PPomerCislo { get; set; }
		public string PomerZacatek { get; set; }
		public string PomerKonec { get; set; }
		public string CinnostSSZ { get; set; }
		public string CinnostDanit { get; set; }
		public string CinnostSocPojist { get; set; }
		public string CinnostZdrPojist { get; set; }
		public string MinimalniZdrPojist { get; set; }
		public string PraxeRoky { get; set; }
		public string PraxeDny { get; set; }
		public string PlatovaTrida { get; set; }
		public string PlatovyStupen { get; set; }
		public string FunkcePopis { get; set; }
		public string DovolenaBeznaNarok { get; set; }
		public string DovolenaDodatNarok { get; set; }
		public string DovolenaJinaNarok { get; set; }
		public string DovolenaLetosni { get; set; }
		public string DovolenaLonska { get; set; }
		public string DovolenaCerpana { get; set; }
		public string DovolenaProplacena { get; set; }
		//public JsonDataUvaz Uvaz { get; set; }
		public string Odmenovani { get; set; }
		public string UvazekDruh { get; set; }
		public string PlnyUvazekHodin { get; set; }
		public string SkutecnyUvazekHodin { get; set; }
		public JsonDataUPom()
		{
			//PPom = new ImportDataPPom();
			//Uvaz = new ImportDataUvaz();

			RokMesicZaznamu = "0";
			OsobniCislo = "0001";
			PPomerCislo = "";
			PomerZacatek = "";
			PomerKonec = "";
			CinnostSSZ = "";
			CinnostDanit = "";
			CinnostSocPojist = "";
			CinnostZdrPojist = "";
			MinimalniZdrPojist = "";
			PraxeRoky = "";
			PraxeDny = "";
			PlatovaTrida = "";
			PlatovyStupen = "";
			FunkcePopis = "";
			DovolenaBeznaNarok = "";
			DovolenaDodatNarok = "";
			DovolenaJinaNarok = "";
			DovolenaLetosni = "";
			DovolenaLonska = "";
			DovolenaCerpana = "";
			DovolenaProplacena = "";

			Odmenovani = "";
			UvazekDruh = "";
			PlnyUvazekHodin = "";
			SkutecnyUvazekHodin = "";
		}
		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesicZaznamu);
		}

		internal long PDovNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaBeznaNarok);
			return (nNumber * 2);
		}

		internal long PDodNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaDodatNarok);
			return (nNumber * 2);
		}

		internal long PJinNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaJinaNarok);
			return (nNumber * 2);
		}

		internal long PDovLetosPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaLetosni);
			return (nNumber * 2);
		}

		internal long PDovLonskPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaLonska);
			return (nNumber * 2);
		}

		internal long PDovXCerpPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaCerpana);
			return (nNumber * 2);
		}

		internal long PDovXPropPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaProplacena);
			return (nNumber * 2);
		}
		internal long PPomPlnyUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PlnyUvazekHodin);
			return (nDataNumb * 60);
		}

		internal long PPomSkutUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(SkutecnyUvazekHodin);
			return (nDataNumb * 60);
		}

		public void CreateImportRecord17(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(17);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomerCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, PomerZacatek);//IMP17_DATUMZAC 
			ImportUtils.AppendField(builder, PomerKonec);//IMP17_DATUMKON 
			ImportUtils.AppendField(builder, CinnostSSZ);//IMP17_CINNOSTSPOJ 
			ImportUtils.AppendField(builder, CinnostDanit);//IMP17_PLATCEDANPR 
			ImportUtils.AppendField(builder, CinnostSocPojist);//IMP17_PLATCESPOJ 
			ImportUtils.AppendField(builder, CinnostZdrPojist);//IMP17_PLATCEZPOJ 
			ImportUtils.AppendEmpty(builder);//IMP17_CINNENIEVID 
			ImportUtils.AppendEmpty(builder);//IMP17_CINBEZDOVOL 
			ImportUtils.AppendEmpty(builder);//IMP17_CINSTSPRAVA 
			ImportUtils.AppendEmpty(builder);//IMP17_NAROKTARIF 
			ImportUtils.AppendField(builder, "");//IMP17_KZAM 
			ImportUtils.AppendEmpty(builder);//IMP17_ISCO 
			ImportUtils.AppendField(builder, PraxeRoky);//IMP17_PRAXEROKY 
			ImportUtils.AppendField(builder, PraxeDny);//IMP17_PRAXEDNY 
			ImportUtils.AppendField(builder, PlatovaTrida);//IMP17_TARIFTRIDA 
			ImportUtils.AppendField(builder, PlatovyStupen);//IMP17_TARIFSTUPEN 
			ImportUtils.AppendEmpty(builder);//IMP17_PSTUPENAUTO 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHPRASTAV 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHNASTUPU 
			ImportUtils.AppendEmpty(builder);//IMP17_SJEDDOBA 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHUKONCEN 
			ImportUtils.AppendEmpty(builder);//IMP17_KVALIFIKACE 
			ImportUtils.AppendField(builder, FunkcePopis);//IMP17_FUNKCE 
			ImportUtils.AppendField(builder, PDovNarokPuldny());//IMP17_NARDOVOL 
			ImportUtils.AppendField(builder, PDodNarokPuldny());//IMP17_NARDODAT 
			ImportUtils.AppendField(builder, PJinNarokPuldny());//IMP17_DOVJINA 
			ImportUtils.AppendField(builder, PDovLetosPuldny());//IMP17_DOVLETOS 
			ImportUtils.AppendField(builder, PDovLonskPuldny());//IMP17_DOVLONI 
			ImportUtils.AppendField(builder, PDovXCerpPuldny());//IMP17_DOCERPANO 
			ImportUtils.AppendField(builder, PDovXPropPuldny());//IMP17_DOPROPLAC 
			ImportUtils.AppendField(builder, MinimalniZdrPojist);//IMP17_MIN_ZP 
			ImportUtils.AppendEmpty(builder);//IMP17_DATVYPOV 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord18(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(18);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomerCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, Odmenovani);//IMP18_ZPODMEN 
			ImportUtils.AppendField(builder, UvazekDruh);//IMP18_DRUHUVAZ 
			ImportUtils.AppendField(builder, PPomPlnyUMinuty());//IMP18_PLNUVAZ 
			ImportUtils.AppendField(builder, PPomSkutUMinuty());//IMP18_SKUTUVAZ 
			ImportUtils.AppendEmpty(builder);//IMP18_KALENUVAZ 
			ImportUtils.AppendField(builder, "");//IMP18_STR 
			ImportUtils.AppendField(builder, "");//IMP18_CIN 
			ImportUtils.AppendEmpty(builder);//IMP18_ZAK 
			ImportUtils.AppendEmpty(builder);//IMP18_TURNDELKA 
			ImportUtils.AppendEmpty(builder);//IMP18_TURNZAC 
			ImportUtils.AppendEmpty(builder);//IMP18_TURNSMEN 
			ImportUtils.AppendEmpty(builder);//DEN_02
			ImportUtils.AppendEmpty(builder);//DEN_03
			ImportUtils.AppendEmpty(builder);//DEN_04
			ImportUtils.AppendEmpty(builder);//DEN_05
			ImportUtils.AppendEmpty(builder);//DEN_06
			ImportUtils.AppendEmpty(builder);//DEN_07
			ImportUtils.AppendEmpty(builder);//DEN_08
			ImportUtils.AppendEmpty(builder);//DEN_09
			ImportUtils.AppendEmpty(builder);//DEN_10
			ImportUtils.AppendEmpty(builder);//DEN_11
			ImportUtils.AppendEmpty(builder);//DEN_12
			ImportUtils.AppendEmpty(builder);//DEN_13
			ImportUtils.AppendEmpty(builder);//DEN_14
			ImportUtils.AppendEmpty(builder);//DEN_15
			ImportUtils.AppendEmpty(builder);//DEN_16
			ImportUtils.AppendEmpty(builder);//DEN_17
			ImportUtils.AppendEmpty(builder);//DEN_18
			ImportUtils.AppendEmpty(builder);//DEN_19
			ImportUtils.AppendEmpty(builder);//DEN_20
			ImportUtils.AppendEmpty(builder);//DEN_21
			ImportUtils.AppendEmpty(builder);//DEN_22
			ImportUtils.AppendEmpty(builder);//DEN_23
			ImportUtils.AppendEmpty(builder);//DEN_24
			ImportUtils.AppendEmpty(builder);//DEN_25
			ImportUtils.AppendEmpty(builder);//DEN_26
			ImportUtils.AppendEmpty(builder);//DEN_27
			ImportUtils.AppendEmpty(builder);//DEN_28
			ImportUtils.AppendEmpty(builder);//IMP18_TURNSMENZAM 
			ImportUtils.AppendEmpty(builder);//IMP18_TURNKALEN 
			ImportUtils.AppendEmpty(builder);//DEN_02
			ImportUtils.AppendEmpty(builder);//DEN_03
			ImportUtils.AppendEmpty(builder);//DEN_04
			ImportUtils.AppendEmpty(builder);//DEN_05
			ImportUtils.AppendEmpty(builder);//DEN_06
			ImportUtils.AppendEmpty(builder);//DEN_07
			ImportUtils.AppendEmpty(builder);//DEN_08
			ImportUtils.AppendEmpty(builder);//DEN_09
			ImportUtils.AppendEmpty(builder);//DEN_10
			ImportUtils.AppendEmpty(builder);//DEN_11
			ImportUtils.AppendEmpty(builder);//DEN_12
			ImportUtils.AppendEmpty(builder);//DEN_13
			ImportUtils.AppendEmpty(builder);//DEN_14
			ImportUtils.AppendEmpty(builder);//DEN_15
			ImportUtils.AppendEmpty(builder);//DEN_16
			ImportUtils.AppendEmpty(builder);//DEN_17
			ImportUtils.AppendEmpty(builder);//DEN_18
			ImportUtils.AppendEmpty(builder);//DEN_19
			ImportUtils.AppendEmpty(builder);//DEN_20
			ImportUtils.AppendEmpty(builder);//DEN_21
			ImportUtils.AppendEmpty(builder);//DEN_22
			ImportUtils.AppendEmpty(builder);//DEN_23
			ImportUtils.AppendEmpty(builder);//DEN_24
			ImportUtils.AppendEmpty(builder);//DEN_25
			ImportUtils.AppendEmpty(builder);//DEN_26
			ImportUtils.AppendEmpty(builder);//DEN_27
			ImportUtils.AppendEmpty(builder);//DEN_28
			ImportUtils.AppendEmpty(builder);//DEN_29
			ImportUtils.AppendEmpty(builder);//DEN_30
			ImportUtils.AppendEmpty(builder);//DEN_31
			ImportUtils.AppendField(builder, "");//IMP18_PRUMVYDHOD 
			ImportUtils.AppendEmpty(builder);//IMP18_ZAPVYDDEN 
			ImportUtils.AppendEmpty(builder);//IMP18_ZVYSZAKLQ1 
			ImportUtils.AppendEmpty(builder);//IMP18_ZVYSZAKLQ2 
			ImportUtils.AppendEmpty(builder);//IMP18_ZVYSZAKLQ3 
			ImportUtils.AppendEmpty(builder);//IMP18_ZVYSZAKLQ4 
			ImportUtils.AppendEmpty(builder);//IMP18_DOVVSVATEK 
			ImportUtils.AppendEmpty(builder);//IMP18_DOVZREZIMU 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}
	}
}

