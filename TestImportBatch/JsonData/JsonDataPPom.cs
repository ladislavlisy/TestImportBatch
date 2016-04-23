using System;

namespace TestImportBatch
{
	public class JsonDataPPom
	{
		public string OsobniCislo { get; set; }
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
		public JsonDataPPom()
		{
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
		}

		internal long PDovNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaBeznaNarok);
			return (nNumber*2);
		}

		internal long PDodNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaDodatNarok);
			return (nNumber*2);
		}

		internal long PJinNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaJinaNarok);
			return (nNumber*2);
		}

		internal long PDovLetosPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaLetosni);
			return (nNumber*2);
		}

		internal long PDovLonskPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaLonska);
			return (nNumber*2);
		}

		internal long PDovXCerpPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaCerpana);
			return (nNumber*2);
		}

		internal long PDovXPropPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(DovolenaProplacena);
			return (nNumber*2);
		}
	}
}

