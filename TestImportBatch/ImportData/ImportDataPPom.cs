using System;

namespace TestImportBatch
{
	public class ImportDataPPom
	{
		public string OsobCislo { get; set; }
		public string PPomCislo { get; set; }
		public string PPomZacat { get; set; }
		public string PPomKonec { get; set; }
		public string PPomerSSZ { get; set; }
		public string PPomDanAN { get; set; }
		public string PPomSocAN { get; set; }
		public string PPomZdrAN { get; set; }
		public string PPomMinZP { get; set; }
		public string PPomPraxR { get; set; }
		public string PPomPraxD { get; set; }
		public string PPomTarTr { get; set; }
		public string PPomTarSt { get; set; }
		public string PPomFunkc { get; set; }
		public string PDovNarok { get; set; }
		public string PDodNarok { get; set; }
		public string PJinNarok { get; set; }
		public string PDovLetos { get; set; }
		public string PDovLonsk { get; set; }
		public string PDovXCerp { get; set; }
		public string PDovXProp { get; set; }
		public ImportDataPPom()
		{
			OsobCislo = "0001";
			PPomCislo = "";
			PPomZacat = "";
			PPomKonec = "";
			PPomerSSZ = "";
			PPomDanAN = "";
			PPomSocAN = "";
			PPomZdrAN = "";
			PPomMinZP = "";
			PPomPraxR = "";
			PPomPraxD = "";
			PPomTarTr = "";
			PPomTarSt = "";
			PPomFunkc = "";
			PDovNarok = "";
			PDodNarok = "";
			PJinNarok = "";
			PDovLetos = "";
			PDovLonsk = "";
			PDovXCerp = "";
			PDovXProp = "";
		}

		internal long PDovNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovNarok);
			return (nNumber*2);
		}

		internal long PDodNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDodNarok);
			return (nNumber*2);
		}

		internal long PJinNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PJinNarok);
			return (nNumber*2);
		}

		internal long PDovLetosPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovLetos);
			return (nNumber*2);
		}

		internal long PDovLonskPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovLonsk);
			return (nNumber*2);
		}

		internal long PDovXCerpPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovXCerp);
			return (nNumber*2);
		}

		internal long PDovXPropPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovXProp);
			return (nNumber*2);
		}
	}
}

