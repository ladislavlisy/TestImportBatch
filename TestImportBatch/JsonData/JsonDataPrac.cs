using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataPrac
	{
		public string RokMesicZaznamu { get; set; }
		public string OsobniCislo { get; set; }
		public string NazevUtvaru { get; set; }
		public string RodinnyStav { get; set; }
		public string RokZacatkuZapoctu { get; set; }
		public string MistoNarozeni { get; set; }
		public string ZpusobVyplaty { get; set; }
		public string KodZdrPojistovny { get; set; }
		public string CisloZdrPojistence { get; set; }
		public string ZdrPojistenecCizinec { get; set; }
		//public JsonDataOsob Osob { get; set; }
		public string Prijmeni { get; set; }
		public string Jmeno { get; set; }
		public string TitulPred { get; set; }
		public string TitulZa { get; set; }
		public string RodneCislo { get; set; }
		//public JsonDataAddr Addr { get; set; }
		public string Ulice { get; set; }
		public string Mesto { get; set; }
		public string CastObce { get; set; }
		public string Posta { get; set; }
		public string DomovniCislo { get; set; }
		public string DomovniCisloTyp { get; set; }
		public string OrientacniCislo { get; set; }
		public string PscCislo { get; set; }
		public string StatAdresy { get; set; }
		//public JsonDataBank Bank { get; set; }
		public string BankovniUcet { get; set; }
		public string BankovniUstav { get; set; }
		public string KonstantniSymbol { get; set; }
		public string VariabilniSymbol { get; set; }
		public string SpecifickySymbol { get; set; }
		//public JsonDataPers Pers { get; set; }
		public string VzdelaniKod { get; set; }
		public string OborVzdelani { get; set; }
		public string RidicPrukaz { get; set; }
		public string TelefonCislo1 { get; set; }
		public string TelefonTyp1 { get; set; }
		public string TelefonCislo2 { get; set; }
		public string TelefonTyp2 { get; set; }
		public string VojakKod { get; set; }
		public string Poznamka { get; set; }
		//public JsonDataProh Proh { get; set; }
		public string RokProhlaseni { get; set; }
		public string ObdobiPrijmu { get; set; }
		public string ObdobiPodepsal { get; set; }
		public string ObdobiInvalida1 { get; set; }
		public string ObdobiInvalida2 { get; set; }
		public string ObdobiInvalida3 { get; set; }
		public string ProvestZuctovani { get; set; }
		public string ZuctovanePrijmy { get; set; }
		public string ZuctovanePojistne { get; set; }
		public string ZuctovaneZalohy { get; set; }
		public string ZuctovaneSlevyPopl { get; set; }
		public string ZuctovaneSlevyDeti { get; set; }
		public string ZuctovaneBonusyDeti { get; set; }
		public string ZuctovanePrispevkyPenz { get; set; }
		public string ZuctovanePrispevkyZivot { get; set; }
		//public JsonDataDane Dane { get; set; }
		public string MesicPodepsal { get; set; }
		public string MesicInvalida1 { get; set; }
		public string MesicInvalida2 { get; set; }
		public string MesicInvalida3 { get; set; }
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
		public JsonDataPrac()
		{
			//Osob = new ImportDataOsob();
			//Addr = new ImportDataAddr();
			//Bank = new ImportDataBank();
			//Pers = new ImportDataPers();
			//Proh = new ImportDataProh();
			//Dane = new ImportDataDane();
			//PPom = new ImportDataPPom();
			//Uvaz = new ImportDataUvaz();

			RokMesicZaznamu = "0";
			OsobniCislo = "0001";
			NazevUtvaru = "UTVAR-001";
			RodinnyStav = "1";
			RokZacatkuZapoctu = "2014";
			MistoNarozeni = "Praha";
			ZpusobVyplaty = "0";
			KodZdrPojistovny = "";
			CisloZdrPojistence = "";
			ZdrPojistenecCizinec = "";

			Prijmeni = "";
			Jmeno = "";
			TitulPred = "";
			TitulZa = "";
			RodneCislo = "";

			Ulice = "";
			Mesto = "";
			CastObce = "";
			Posta = "";
			DomovniCislo = "";
			DomovniCisloTyp = "";
			PscCislo = "";
			StatAdresy = "";

			BankovniUcet = "";
			BankovniUstav = "";
			KonstantniSymbol = "";
			VariabilniSymbol = "";
			SpecifickySymbol = "";

			VzdelaniKod = "";
			OborVzdelani = "";
			RidicPrukaz = "";
			TelefonCislo1 = "";
			TelefonTyp1 = "";
			TelefonCislo2 = "";
			TelefonTyp2 = "";
			VojakKod = "";
			Poznamka = "";

			RokProhlaseni = "";
			ObdobiPrijmu = "";
			ObdobiPodepsal = "";
			ObdobiInvalida1 = "";
			ObdobiInvalida2 = "";
			ObdobiInvalida3 = "";
			ProvestZuctovani = "";
			ZuctovanePrijmy = "";
			ZuctovanePojistne = "";
			ZuctovaneZalohy = "";
			ZuctovaneSlevyPopl = "";
			ZuctovaneSlevyDeti = "";
			ZuctovaneBonusyDeti = "";
			ZuctovanePrispevkyPenz = "";
			ZuctovanePrispevkyZivot = "";

			MesicPodepsal = "";
			MesicInvalida1 = "";
			MesicInvalida2 = "";
			MesicInvalida3 = "";

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

		public long RokZacatek()
		{
			return UtilsTable.RokMes(RokZacatkuZapoctu);
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
		public void CreateImportRecord01(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(1);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, RodneCislo);//IMP01_RODCIS 
			ImportUtils.AppendField(builder, Prijmeni);//IMP01_RODPRIJ 
			ImportUtils.AppendField(builder, NazevUtvaru);//IMP01_UTVAR 
			ImportUtils.AppendEmpty(builder);//IMP01_STRED 
			ImportUtils.AppendEmpty(builder);//IMP01_CINN 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAK 
			ImportUtils.AppendField(builder, Prijmeni);//IMP01_PRIJ 
			ImportUtils.AppendField(builder, Jmeno);//IMP01_JMENO 
			ImportUtils.AppendField(builder, TitulPred);//IMP01_TITULPRED 
			ImportUtils.AppendField(builder, TitulZa);//IMP01_TITULZA 
			ImportUtils.AppendEmpty(builder);//IMP01_DALSIPRIJ 
			ImportUtils.AppendField(builder, MistoNarozeni);//IMP01_MISTONAR 
			ImportUtils.AppendField(builder, RodinnyStav);//IMP01_RODSTAV 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAPOCETROKY 
			ImportUtils.AppendEmpty(builder);//IMP01_ZAPOCETDNY 
			ImportUtils.AppendField(builder, "1.1." + RokZacatkuZapoctu);//IMP01_ZAPOCETDATE 
			ImportUtils.AppendField(builder, Mesto);//IMP_ADRESA_OBEC 
			ImportUtils.AppendField(builder, CastObce);//IMP_ADRESA_COBEC 
			ImportUtils.AppendField(builder, DomovniCislo);//IMP_ADRESA_DCIS 
			ImportUtils.AppendField(builder, DomovniCisloTyp);//IMP_ADRESA_DTYP 
			ImportUtils.AppendField(builder, Ulice);//IMP_ADRESA_ULICE 
			ImportUtils.AppendField(builder, PscCislo);//IMP_ADRESA_PSC 
			ImportUtils.AppendField(builder, Posta);//IMP_ADRESA_POSTA 
			ImportUtils.AppendField(builder, OrientacniCislo);//IMP_ADRESA_OCIS 
			ImportUtils.AppendField(builder, StatAdresy);//IMP_ADRESA_STAT
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

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, ZpusobVyplaty);//IMP02_ZPUSOB
			ImportUtils.AppendEmpty(builder);//IMP02_OBEC
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_COBEC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_DTYP 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_ULICE 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_PSC 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_POSTA 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_OCIS 
			ImportUtils.AppendEmpty(builder);//IMP_ADRESA_STAT
			ImportUtils.AppendField(builder, BankovniUcet);//IMP_BKSPOJ_UCET 
			ImportUtils.AppendField(builder, BankovniUstav);//IMP_BKSPOJ_USTAV 
			ImportUtils.AppendField(builder, KonstantniSymbol);//IMP_BKSPOJ_KSYMB 
			ImportUtils.AppendField(builder, VariabilniSymbol);//IMP_BKSPOJ_VSYMB 
			ImportUtils.AppendField(builder, SpecifickySymbol);//IMP_BKSPOJ_SSYMB 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord03(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(3);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, VzdelaniKod);//IMP03_VZDELNEJ 
			ImportUtils.AppendField(builder, OborVzdelani);//IMP03_VZDELOBOR 
			ImportUtils.AppendEmpty(builder);//IMP03_JKOV 
			ImportUtils.AppendField(builder, RidicPrukaz);//IMP03_RIDIC 
			ImportUtils.AppendField(builder, TelefonCislo1);//IMP03_TEL1CIS 
			ImportUtils.AppendField(builder, TelefonTyp1);//IMP03_TEL1TYP 
			ImportUtils.AppendField(builder, TelefonCislo2);//IMP03_TEL2CIS 
			ImportUtils.AppendField(builder, TelefonTyp2);//IMP03_TEL2TYP 
			ImportUtils.AppendField(builder, VojakKod);//IMP03_VOJAK 
			ImportUtils.AppendEmpty(builder);//IMP03_OSDATA 
			ImportUtils.AppendEmpty(builder);//IMP03_PREDCHOZI 
			ImportUtils.AppendField(builder, Poznamka);//IMP03_POZNAMKA 
			ImportUtils.AppendField(builder, "");//IMP03_PRACMAIL 
			ImportUtils.AppendField(builder, "");//IMP03_PDFHESLO 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord05(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(5);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, KodZdrPojistovny);//IMP05_KODZDRAVPOJ 
			ImportUtils.AppendEmpty(builder);//IMP05_MISTOZDRAVP 
			ImportUtils.AppendField(builder, CisloZdrPojistence);//IMP05_CISLOPOJIST 
			ImportUtils.AppendField(builder, ZdrPojistenecCizinec);//IMP05_ZPOJCIZINEC 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}


		public void CreateImportRecord07(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(7);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, RokProhlaseni);// IMP00_ROK = 3;
			ImportUtils.AppendField(builder, ObdobiPrijmu);// IMP07_PRIJMYZAOBD = 4;
			ImportUtils.AppendField(builder, ObdobiPodepsal);// IMP07_PODEPSAL = 5;
			ImportUtils.AppendField(builder, ObdobiInvalida1);// IMP07_INVALIDITA1 = 6;
			ImportUtils.AppendField(builder, ObdobiInvalida2);// IMP07_INVALIDITA2 = 7;
			ImportUtils.AppendField(builder, ObdobiInvalida3);// IMP07_INVALIDITA3 = 8;
			ImportUtils.AppendField(builder, ZuctovanePrijmy);// IMP07_PRIJEM = 9;
			ImportUtils.AppendField(builder, ZuctovanePojistne);// IMP07_POJISTNE = 10;
			ImportUtils.AppendField(builder, ZuctovaneZalohy);// IMP07_ZALOHA = 11;
			ImportUtils.AppendField(builder, ProvestZuctovani);// IMP07_DANZUCTOVAT = 12;
			ImportUtils.AppendField(builder, ZuctovaneSlevyPopl);// IMP07_SLEVAB = 13;
			ImportUtils.AppendField(builder, ZuctovaneSlevyDeti);// IMP07_SLEVAC = 14;
			ImportUtils.AppendField(builder, ZuctovaneBonusyDeti);// IMP07_BONUSC = 15;
			ImportUtils.AppendField(builder, ZuctovanePrispevkyPenz);// IMP07_PENZPPR = 16;
			ImportUtils.AppendField(builder, ZuctovanePrispevkyZivot);// IMP07_KZIVPPR = 17;
			ImportUtils.AppendField(builder, "");// IMP07_REZIDENT = 18;

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		public void CreateImportRecord08(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(8);

			ImportUtils.AppendField(builder, OsobniCislo);//IMP00_OSOBCISLO
			ImportUtils.AppendField(builder, MesicPodepsal);//IMP08_PODEPSAL 
			ImportUtils.AppendField(builder, MesicInvalida1);//IMP08_INVALIDITA1 
			ImportUtils.AppendField(builder, MesicInvalida2);//IMP08_INVALIDITA2 
			ImportUtils.AppendField(builder, MesicInvalida3);//IMP08_INVALIDITA3 

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
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

