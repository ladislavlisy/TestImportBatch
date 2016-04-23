using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataPrac
	{
		public string RokMesPoc { get; set; }
		public string OsobCislo { get; set; }
		public string PracUtvar { get; set; }
		public string PracRodSt { get; set; }
		public string RokZZacat { get; set; }
		public string MisNaroze { get; set; }
		public string VypZpusob { get; set; }
		public string KodZdravP { get; set; }
		public string CisPojist { get; set; }
		public string CizinecZP { get; set; }
		//public ImportDataOsob Osob { get; set; }
		public string PracPrijm { get; set; }
		public string PracJmeno { get; set; }
		public string PracTitul { get; set; }
		public string PracTitZa { get; set; }
		public string PracRodne { get; set; }
		//public ImportDataAddr Addr { get; set; }
		public string AdrTUlice { get; set; }
		public string AdrTMesto { get; set; }
		public string AdrTOCast { get; set; }
		public string AdrTPosta { get; set; }
		public string AdrTDomCs { get; set; }
		public string AdrTDomDr { get; set; }
		public string AdrTOriCs { get; set; }
		public string AdrTPscCs { get; set; }
		public string AdrTStatK { get; set; }
		//public ImportDataBank Bank { get; set; }
		public string VypBkUcet { get; set; }
		public string VypBkBank { get; set; }
		public string VypBkKSym { get; set; }
		public string VypBkVSym { get; set; }
		public string VypBkSSym { get; set; }
		//public ImportDataPers Pers { get; set; }
		public string PersVzdel { get; set; }
		public string PersOborV { get; set; }
		public string PersRidic { get; set; }
		public string PersTelC1 { get; set; }
		public string PersTelT1 { get; set; }
		public string PersTelC2 { get; set; }
		public string PersTelT2 { get; set; }
		public string PersVojak { get; set; }
		public string PPoznamka { get; set; }
		//public ImportDataProh Proh { get; set; }
		public string ProhObdob { get; set; }
		public string ProhPrijX { get; set; }
		public string ProhPodep { get; set; }
		public string ProhInv01 { get; set; }
		public string ProhInv02 { get; set; }
		public string ProhInv03 { get; set; }
		public string ProhZuctA { get; set; }
		public string ProhPrijK { get; set; }
		public string ProhPojis { get; set; }
		public string ProhZaloh { get; set; }
		public string ProhPoplS { get; set; }
		public string ProhDetiS { get; set; }
		public string ProhDetiB { get; set; }
		public string ProhPrisP { get; set; }
		public string ProhPrisZ { get; set; }
		//public ImportDataDane Dane { get; set; }
		public string DanePodep { get; set; }
		public string DaneInv01 { get; set; }
		public string DaneInv02 { get; set; }
		public string DaneInv03 { get; set; }
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
		public ImportDataPrac()
		{
			//Osob = new ImportDataOsob();
			//Addr = new ImportDataAddr();
			//Bank = new ImportDataBank();
			//Pers = new ImportDataPers();
			//Proh = new ImportDataProh();
			//Dane = new ImportDataDane();
			//PPom = new ImportDataPPom();
			//Uvaz = new ImportDataUvaz();

			RokMesPoc = "0";
			OsobCislo = "0001";
			PracUtvar = "UTVAR-001";
			PracRodSt = "1";
			RokZZacat = "2014";
			MisNaroze = "Praha";
			VypZpusob = "0";
			KodZdravP = "";
			CisPojist = "";
			CizinecZP = "";

			PracPrijm = "";
			PracJmeno = "";
			PracTitul = "";
			PracTitZa = "";
			PracRodne = "";

			AdrTUlice = "";
			AdrTMesto = "";
			AdrTOCast = "";
			AdrTPosta = "";
			AdrTDomCs = "";
			AdrTDomDr = "";
			AdrTPscCs = "";
			AdrTStatK = "";

			VypBkUcet = "";
			VypBkBank = "";
			VypBkKSym = "";
			VypBkVSym = "";
			VypBkSSym = "";

			PersVzdel = "";
			PersOborV = "";
			PersRidic = "";
			PersTelC1 = "";
			PersTelT1 = "";
			PersTelC2 = "";
			PersTelT2 = "";
			PersVojak = "";
			PPoznamka = "";

			ProhObdob = "";
			ProhPrijX = "";
			ProhPodep = "";
			ProhInv01 = "";
			ProhInv02 = "";
			ProhInv03 = "";
			ProhZuctA = "";
			ProhPrijK = "";
			ProhPojis = "";
			ProhZaloh = "";
			ProhPoplS = "";
			ProhDetiS = "";
			ProhDetiB = "";
			ProhPrisP = "";
			ProhPrisZ = "";

			DanePodep = "";
			DaneInv01 = "";
			DaneInv02 = "";
			DaneInv03 = "";

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

		public long RokZacatek()
		{
			return UtilsTable.RokMes(RokZZacat);
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
		public void CreateImportRecord01(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(1);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PracRodne);//IMP01_RODCIS 
			ImportUtils.AppendField(builder, PracPrijm);//IMP01_RODPRIJ 
			ImportUtils.AppendField(builder, PracUtvar);//IMP01_UTVAR 
			ImportUtils.AppendEmpty(builder);//IMP01_STRED 
			ImportUtils.AppendEmpty(builder);//IMP01_CINN 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAK 
			ImportUtils.AppendField(builder, PracPrijm);//IMP01_PRIJ 
			ImportUtils.AppendField(builder, PracJmeno);//IMP01_JMENO 
			ImportUtils.AppendField(builder, PracTitul);//IMP01_TITULPRED 
			ImportUtils.AppendField(builder, PracTitZa);//IMP01_TITULZA 
			ImportUtils.AppendEmpty(builder);//IMP01_DALSIPRIJ 
			ImportUtils.AppendField(builder, MisNaroze);//IMP01_MISTONAR 
			ImportUtils.AppendField(builder, PracRodSt);//IMP01_RODSTAV 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAPOCETROKY 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAPOCETDNY 
			ImportUtils.AppendField(builder, "1.1." + RokZZacat);//IMP01_ZAPOCETDATE 
			ImportUtils.AppendField(builder, AdrTMesto);//IMP_ADRESA_OBEC 
			ImportUtils.AppendField(builder, AdrTOCast);//IMP_ADRESA_COBEC 
			ImportUtils.AppendField(builder, AdrTDomCs);//IMP_ADRESA_DCIS 
			ImportUtils.AppendField(builder, AdrTDomDr);//IMP_ADRESA_DTYP 
			ImportUtils.AppendField(builder, AdrTUlice);//IMP_ADRESA_ULICE 
			ImportUtils.AppendField(builder, AdrTPscCs);//IMP_ADRESA_PSC 
			ImportUtils.AppendField(builder, AdrTPosta);//IMP_ADRESA_POSTA 
			ImportUtils.AppendField(builder, AdrTOriCs);//IMP_ADRESA_OCIS 
			ImportUtils.AppendField(builder, AdrTStatK);//IMP_ADRESA_STAT
			ImportUtils.AppendEmpty(builder);//IMP01_POCETDETI 
			ImportUtils.AppendEmpty(builder);//IMP01_DUCHDATUM 
			ImportUtils.AppendEmpty(builder);//IMP01_DUCHDRUH 
			ImportUtils.AppendField(builder, "");//IMP01_ZDRAVSTAV 
			ImportUtils.AppendField(builder, "");//IMP01_OBCANSTVI 
			ImportUtils.AppendEmpty(builder);//IMP01_PRUKAZOBCAN 
			ImportUtils.AppendEmpty(builder);//IMP01_PRUKAZPAS 
			ImportUtils.AppendEmpty(builder);//IMP01_RODCIS_JINE 
			ImportUtils.AppendField(builder, "");//IMP01_STATNAR 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord02(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(2);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, VypZpusob);//IMP02_ZPUSOB
			ImportUtils.AppendEmpty(builder);//IMP02_OBEC
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_COBEC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DTYP 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_ULICE 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_PSC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_POSTA 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_OCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_STAT
			ImportUtils.AppendField(builder, VypBkUcet);//IMP_BKSPOJ_UCET 
			ImportUtils.AppendField(builder, VypBkBank);//IMP_BKSPOJ_USTAV 
			ImportUtils.AppendField(builder, VypBkKSym);//IMP_BKSPOJ_KSYMB 
			ImportUtils.AppendField(builder, VypBkVSym);//IMP_BKSPOJ_VSYMB 
			ImportUtils.AppendField(builder, VypBkSSym);//IMP_BKSPOJ_SSYMB 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord03(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(3);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, PersVzdel);//IMP03_VZDELNEJ 
			ImportUtils.AppendField(builder, PersOborV);//IMP03_VZDELOBOR 
			ImportUtils.AppendEmpty(builder);//IMP03_JKOV 
			ImportUtils.AppendField(builder, PersRidic);//IMP03_RIDIC 
			ImportUtils.AppendField(builder, PersTelC1);//IMP03_TEL1CIS 
			ImportUtils.AppendField(builder, PersTelT1);//IMP03_TEL1TYP 
			ImportUtils.AppendField(builder, PersTelC2);//IMP03_TEL2CIS 
			ImportUtils.AppendField(builder, PersTelT2);//IMP03_TEL2TYP 
			ImportUtils.AppendField(builder, PersVojak);//IMP03_VOJAK 
			ImportUtils.AppendEmpty(builder);//IMP03_OSDATA 
			ImportUtils.AppendEmpty(builder);//IMP03_PREDCHOZI 
			ImportUtils.AppendField(builder, PPoznamka);//IMP03_POZNAMKA 
			ImportUtils.AppendField(builder, "");//IMP03_PRACMAIL 
			ImportUtils.AppendField(builder, "");//IMP03_PDFHESLO 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord05(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(5);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, KodZdravP);//IMP05_KODZDRAVPOJ 
			ImportUtils.AppendEmpty(builder);//IMP05_MISTOZDRAVP 
			ImportUtils.AppendField(builder, CisPojist);//IMP05_CISLOPOJIST 
			ImportUtils.AppendField(builder, CizinecZP);//IMP05_ZPOJCIZINEC 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}


		public void CreateImportRecord07(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(7);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, ProhObdob);// IMP00_ROK = 3;
			ImportUtils.AppendField(builder, ProhPrijX);// IMP07_PRIJMYZAOBD = 4;
			ImportUtils.AppendField(builder, ProhPodep);// IMP07_PODEPSAL = 5;
			ImportUtils.AppendField(builder, ProhInv01);// IMP07_INVALIDITA1 = 6;
			ImportUtils.AppendField(builder, ProhInv02);// IMP07_INVALIDITA2 = 7;
			ImportUtils.AppendField(builder, ProhInv03);// IMP07_INVALIDITA3 = 8;
			ImportUtils.AppendField(builder, ProhPrijK);// IMP07_PRIJEM = 9;
			ImportUtils.AppendField(builder, ProhPojis);// IMP07_POJISTNE = 10;
			ImportUtils.AppendField(builder, ProhZaloh);// IMP07_ZALOHA = 11;
			ImportUtils.AppendField(builder, ProhZuctA);// IMP07_DANZUCTOVAT = 12;
			ImportUtils.AppendField(builder, ProhPoplS);// IMP07_SLEVAB = 13;
			ImportUtils.AppendField(builder, ProhDetiS);// IMP07_SLEVAC = 14;
			ImportUtils.AppendField(builder, ProhDetiB);// IMP07_BONUSC = 15;
			ImportUtils.AppendField(builder, ProhPrisP);// IMP07_PENZPPR = 16;
			ImportUtils.AppendField(builder, ProhPrisZ);// IMP07_KZIVPPR = 17;
			ImportUtils.AppendField(builder, "");// IMP07_REZIDENT = 18;

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord08(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(8);

			ImportUtils.AppendField(builder, OsobCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, DanePodep);//IMP08_PODEPSAL 
			ImportUtils.AppendField(builder, DaneInv01);//IMP08_INVALIDITA1 
			ImportUtils.AppendField(builder, DaneInv02);//IMP08_INVALIDITA2 
			ImportUtils.AppendField(builder, DaneInv03);//IMP08_INVALIDITA3 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
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

