using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataUPom
	{
		public string RokMesPoc { get; set; }
		public string OsobCislo { get; set; }
		//public ImportDataPPom PPom { get; set; }
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
		//public ImportDataUvaz Uvaz { get; set; }
		public string PPomOdmen { get; set; }
		public string PPomDUvaz { get; set; }
		public string PPomPlnyU { get; set; }
		public string PPomSkutU { get; set; }
		public ImportDataUPom()
		{
			//PPom = new ImportDataPPom();
			//Uvaz = new ImportDataUvaz();

			RokMesPoc = "0";
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

			PPomCislo = "";
			PPomOdmen = "";
			PPomDUvaz = "";
			PPomPlnyU = "";
			PPomSkutU = "";
		}
		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesPoc);
		}

		internal long PDovNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovNarok);
			return (nNumber * 2);
		}

		internal long PDodNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDodNarok);
			return (nNumber * 2);
		}

		internal long PJinNarokPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PJinNarok);
			return (nNumber * 2);
		}

		internal long PDovLetosPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovLetos);
			return (nNumber * 2);
		}

		internal long PDovLonskPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovLonsk);
			return (nNumber * 2);
		}

		internal long PDovXCerpPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovXCerp);
			return (nNumber * 2);
		}

		internal long PDovXPropPuldny()
		{
			long nNumber = UtilsTable.Int32ParseNumber(PDovXProp);
			return (nNumber * 2);
		}
		internal long PPomPlnyUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PPomPlnyU);
			return (nDataNumb * 60);
		}

		internal long PPomSkutUMinuty()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(PPomSkutU);
			return (nDataNumb * 60);
		}
		public void CreateImportRecord17(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(17);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, PPomZacat);//IMP17_DATUMZAC 
			ImportUtils.AppendField(builder, PPomKonec);//IMP17_DATUMKON 
			ImportUtils.AppendField(builder, PPomerSSZ);//IMP17_CINNOSTSPOJ 
			ImportUtils.AppendField(builder, PPomDanAN);//IMP17_PLATCEDANPR 
			ImportUtils.AppendField(builder, PPomSocAN);//IMP17_PLATCESPOJ 
			ImportUtils.AppendField(builder, PPomZdrAN);//IMP17_PLATCEZPOJ 
			ImportUtils.AppendEmpty(builder);//IMP17_CINNENIEVID 
			ImportUtils.AppendEmpty(builder);//IMP17_CINBEZDOVOL 
			ImportUtils.AppendEmpty(builder);//IMP17_CINSTSPRAVA 
			ImportUtils.AppendEmpty(builder);//IMP17_NAROKTARIF 
			ImportUtils.AppendField(builder, "");//IMP17_KZAM 
			ImportUtils.AppendEmpty(builder);//IMP17_ISCO 
			ImportUtils.AppendField(builder, PPomPraxR);//IMP17_PRAXEROKY 
			ImportUtils.AppendField(builder, PPomPraxD);//IMP17_PRAXEDNY 
			ImportUtils.AppendField(builder, PPomTarTr);//IMP17_TARIFTRIDA 
			ImportUtils.AppendField(builder, PPomTarSt);//IMP17_TARIFSTUPEN 
			ImportUtils.AppendEmpty(builder);//IMP17_PSTUPENAUTO 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHPRASTAV 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHNASTUPU 
			ImportUtils.AppendEmpty(builder);//IMP17_SJEDDOBA 
			ImportUtils.AppendEmpty(builder);//IMP17_DRUHUKONCEN 
			ImportUtils.AppendEmpty(builder);//IMP17_KVALIFIKACE 
			ImportUtils.AppendField(builder, PPomFunkc);//IMP17_FUNKCE 
			ImportUtils.AppendField(builder, PDovNarokPuldny());//IMP17_NARDOVOL 
			ImportUtils.AppendField(builder, PDodNarokPuldny());//IMP17_NARDODAT 
			ImportUtils.AppendField(builder, PJinNarokPuldny());//IMP17_DOVJINA 
			ImportUtils.AppendField(builder, PDovLetosPuldny());//IMP17_DOVLETOS 
			ImportUtils.AppendField(builder, PDovLonskPuldny());//IMP17_DOVLONI 
			ImportUtils.AppendField(builder, PDovXCerpPuldny());//IMP17_DOCERPANO 
			ImportUtils.AppendField(builder, PDovXPropPuldny());//IMP17_DOPROPLAC 
			ImportUtils.AppendField(builder, PPomMinZP);//IMP17_MIN_ZP 
			ImportUtils.AppendEmpty(builder);//IMP17_DATVYPOV 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord18(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(18);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PPomCislo);//IMP17_PPOMER 
			ImportUtils.AppendField(builder, PPomOdmen);//IMP18_ZPODMEN 
			ImportUtils.AppendField(builder, PPomDUvaz);//IMP18_DRUHUVAZ 
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

