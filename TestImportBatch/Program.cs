using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Linq;

namespace TestImportBatch
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			RunParams testFolders = new RunParams();

			testFolders.SetDirectoryVariables (args);

			JsonDataParams testData = new JsonDataParams ();

			string sRokMesFrom = "1501";
			string sRokMesUpto = "1512";

			testData.PrepareImportProccess (args, sRokMesFrom, sRokMesUpto);

			CreateImportFileXJSON (testData, testFolders.OldTestFolders.PathImportTxtFolder, "XX", RunParams.MS_SQL_ARCHIVACE_RUN);

			Console.WriteLine ("Completed!");
		}

		private static string CreateImportFileXJSON(JsonDataParams data, string pathImportTxtFolder, string fileImportPref, int archivaceRun)
		{
			const long PRE_IMPORT_ARCHIVACE = 0;

			string sRokMesFrom = data.RokMesFrom;
			string sRokMesUpto = data.RokMesUpto;

			string suiteFileName = fileImportPref + "_IMPORT_JSON_MAIN.TXT";

			string testSuiteImportFile = System.IO.Path.Combine(pathImportTxtFolder, suiteFileName);

			long nRokMesFrom = UtilsTable.RokMes(sRokMesFrom);
			long nRokMesUpto = UtilsTable.RokMes(sRokMesUpto);

			using (TextWriter writerSuite = new StreamWriter(testSuiteImportFile, false, Encoding.GetEncoding("windows-1250")))
			{
				AddCreateFirmaDavka(writerSuite, UtilsTable.RokNumber(sRokMesFrom), UtilsTable.MesNumber(sRokMesFrom), "TEST_XCSV_2015");

				foreach (var vyuct in data.Vyuct)
				{
					if (nRokMesFrom <= vyuct.RokMesPocitany() && nRokMesUpto >= vyuct.RokMesPocitany())
					{
						var importListMesRokPPrac = data.PPrac.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu)).ToList();

						var importListMesRokDDeti = data.DDeti.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu)).ToList();

						var importListMesRokMMzda = data.MMzda.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu && c.RokMesicZadani == vyuct.RokMesicZaznamu)).ToList();

						var importListMesRokORMes = data.MMzda
							.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu && c.RokMesicZadani != vyuct.RokMesicZaznamu))
							.Select((v) => (v.RokMesicZadani))
							.OrderBy((o) => (o)).ToList();

						var importListMesRokSestR = data.SestR.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu)).ToList();

						string fileNamePPrac = fileImportPref + "_" + vyuct.RokMesicZaznamu + "_IMPORT_PRAC.TXT";

						string filePathPPrac = System.IO.Path.Combine(pathImportTxtFolder, fileNamePPrac);

						string fileNameMMzda = fileImportPref + "_" + vyuct.RokMesicZaznamu + "_IMPORT_MZDA.TXT";

						string filePathMMzda = System.IO.Path.Combine(pathImportTxtFolder, fileNameMMzda);

						if (importListMesRokPPrac.Count > 0 || importListMesRokDDeti.Count > 0)
						{
							using (TextWriter writer = new StreamWriter(filePathPPrac, false, Encoding.GetEncoding("windows-1250")))
							{
								foreach (var pprac in importListMesRokPPrac)
								{
									pprac.CreateImportRecord01(writer);
									pprac.CreateImportRecord02(writer);
									pprac.CreateImportRecord03(writer);
									pprac.CreateImportRecord05(writer);
									pprac.CreateImportRecord07(writer);
									pprac.CreateImportRecord08(writer);
									pprac.CreateImportRecord17(writer);
									pprac.CreateImportRecord18(writer);
								}
								foreach (var ddeti in importListMesRokDDeti)
								{
									ddeti.CreateImportRecord09(writer);
								}
								writer.Close();
							}
							AddImportFDavka(writerSuite, vyuct.RokPocitany(), vyuct.MesPocitany(), filePathPPrac, vyuct.ArchivNazev + vyuct.RokMesicZaznamu, PRE_IMPORT_ARCHIVACE);
						}

						if (importListMesRokMMzda.Count > 0)
						{
							using (TextWriter writer = new StreamWriter(filePathMMzda, false, Encoding.GetEncoding("windows-1250")))
							{
								foreach (var mmzda in importListMesRokMMzda)
								{
									mmzda.CreateImportRecord19(writer);
								}
								writer.Close();
							}
							AddImportFDavka(writerSuite, vyuct.RokPocitany(), vyuct.MesPocitany(), filePathMMzda, vyuct.ArchivNazev + vyuct.RokMesicZaznamu, PRE_IMPORT_ARCHIVACE);
						}

						foreach (var ormes in importListMesRokORMes)
						{
							string fileNameOMzda = fileImportPref + "_" + vyuct.RokMesicZaznamu + ormes + "_IMPORT_OMIN.TXT";

							string filePathOMzda = System.IO.Path.Combine(pathImportTxtFolder, fileNameOMzda);

							var importListMesRokOMzda = data.MMzda.Where((c) => (c.RokMesicZaznamu == vyuct.RokMesicZaznamu && c.RokMesicZadani == ormes)).ToList();

							if (importListMesRokOMzda.Count > 0)
							{
								using (TextWriter writer = new StreamWriter(filePathOMzda, false, Encoding.GetEncoding("windows-1250")))
								{
									foreach (var mmzda in importListMesRokOMzda)
									{
										mmzda.CreateImportRecord19(writer);
									}
									writer.Close();
								}
								AddImportFDavka(writerSuite, UtilsTable.RokNumber(ormes), UtilsTable.MesNumber(ormes), filePathOMzda, vyuct.ArchivNazev + vyuct.RokMesicZaznamu, PRE_IMPORT_ARCHIVACE);
							}
						}

						foreach (var sestr in importListMesRokSestR)
						{
							sestr.CreateImportRecord154(writerSuite);
						}

						AddVyuctovDavka(writerSuite, vyuct.RokPocitany(), vyuct.MesPocitany(), vyuct.ArchivNazev, vyuct.IsArchivRun(), vyuct.IsReportRun());
					}
				}
				AddUploadFirmaDavka(writerSuite, UtilsTable.RokNumber(sRokMesFrom), UtilsTable.MesNumber(sRokMesFrom), RunParams.TEST_OSOBUTVAR_DAVKA);

				writerSuite.Close();
			}

			return testSuiteImportFile;
		}
		private static void AddCreateFirmaDavka(TextWriter writer, long vRokImp, long vMesImp, string testName)
		{
			StringBuilder builder = ImportUtils.CreateLine(151);

			ImportUtils.AppendField(builder, "1");
			ImportUtils.AppendField(builder, vMesImp);
			ImportUtils.AppendField(builder, vRokImp);
			ImportUtils.AppendField(builder, testName);

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		private static void AddImportFDavka(TextWriter writer, long vRokImp, long vMesImp, string testFile, string archivSub, long archivRun)
		{
			StringBuilder builder = ImportUtils.CreateLine(152);

			ImportUtils.AppendField(builder, "1");
			ImportUtils.AppendField(builder, vMesImp);
			ImportUtils.AppendField(builder, vRokImp);
			ImportUtils.AppendField(builder, testFile);
			ImportUtils.AppendField(builder, archivRun);
			ImportUtils.AppendField(builder, archivSub);

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}

		private static void AddVyuctovDavka(TextWriter writer, long vRokImp, long vMesImp, string archivSub, long archivRun, long reportRun)
		{
			StringBuilder builder = ImportUtils.CreateLine(153);

			ImportUtils.AppendField(builder, "1");
			ImportUtils.AppendField(builder, vMesImp);
			ImportUtils.AppendField(builder, vRokImp);
			ImportUtils.AppendEmpty(builder);
			ImportUtils.AppendField(builder, archivRun);
			ImportUtils.AppendField(builder, archivSub);
			ImportUtils.AppendField(builder, reportRun);

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}
		private static void AddUploadFirmaDavka(TextWriter writer, long vRokImp, long vMesImp, string utvarName)
		{
			string utvarTemplate = "@101||{0}|OJ-001||Česká republika|Vedoucí|||";

			string utvarImResult = string.Format(utvarTemplate, utvarName);

			writer.WriteLine("@100||1|OKsystem s.r.o.|Praha|||27373665|CZ27373665|Praha||125|1|Na Pankráci|14021|Praha 4|||48973004|2700||||");
			writer.WriteLine("@100||3|Česká správa sociálního zabezpečení|Praha 8|||ČSSZ||Praha 8||1997|1|Trojská|18200|Praha 8|13a||1011-3237-011|0710|7618|15010769||");
			writer.WriteLine("@100||4|Finanční úřad|Praha 5|||||Praha 5||61|1|Peroutkova|15000||||7624-051|0710|8148|47608676||");
			writer.WriteLine("@100||5|ABN AMRO Bank N. V.|Praha|ABNA ||5400|ABNACZPP|Praha||745|1|Jungmannova|11000|Praha 1|24|CZE||||||");
			writer.WriteLine("@100||5|BAWAG Bank CZ, a.s.|Praha|DRES ||4000|SOLACZPP|Praha||795|1|Václavské náměstí|11000|Praha 1|40|CZE||||||");
			writer.WriteLine("@100||5|Bank of Tokyo-Mitsubishi UFJ (Holland) N.V. Prague Branch, organizační složka|Praha|BOTK||2020|BOTKCZPP|Praha||3208|1|Klicperova|15000|Praha 5|12|CZE||||||");
			writer.WriteLine("@100||5|CALYON S. A., organizační složka|Praha|CRLY||5000|CRLYCZPP|Praha||1096|1|Ovocný trh|11719|Praha 1|8|CZE||||||");
			writer.WriteLine("@100||5|Citibank, a.s.|Praha|CITI||2600|CITICZPX|Praha||423|1|Evropská|16640|Praha 6|178|CZE||||||");
			writer.WriteLine("@100||5|COMMERZBANK Aktiengesellschaft, pobočka Praha|Praha|COBA||6200|COBACZPX|Praha||934|1|Jugoslávská|12021|Praha 2|1|CZE||||||");
			writer.WriteLine("@100||5|Česká národní banka (centrální banka)|Praha|CNBA||0710|CNBACZPP|Praha||864|1|Na Příkopě|11503|Praha 1|28|CZE||||||");
			writer.WriteLine("@100||5|Česká spořitelna, a.s.|Praha|CSPO||0800|GIBACZPX|Praha||1929|1|Olbrachtova|14000|Praha 4|62|CZE||||||");
			writer.WriteLine("@100||5|Českomoravská stavební spořitelna, a.s.|Praha|CMSS||7960|NEMÁ KÓD|Praha||3218|1|Vinohradská|10017|Praha 10|169|CZE||||||");
			writer.WriteLine("@100||5|Českomoravská záruční a rozvojová banka, a.s.|Praha|CMZR||4300|CMZRCZP1|Praha||964|1|Jeruzalémská|11021|Praha 1|4|CZE||||||");
			writer.WriteLine("@100||5|Československá obchodní banka, a.s.|Praha|CEKO||0300|CEKOCZPP|Praha||854|1|Na Příkopě|11520|Praha 1|14|CZE||||||");
			writer.WriteLine("@100||5|Deutsche Bank Aktiengesellschaft Filiale Prag, organizační složka|Praha|DEUT||7910|DEUTCZPX|Praha||750|1|Jungmannova|11000|Praha 1|34|CZE||||||");
			writer.WriteLine("@100||5|eBanka, a.s.|Praha|EXPA||5500|RZBCCZPP|Praha||1096|1|Na Příkopě|11719|Praha 1|19|CZE||||||");
			writer.WriteLine("@100||5|Fortis Bank SA/NV, pobočka Česká republika |Praha|GEBA||6300|GEBACZPP|Praha||1096|1|Ovocný trh|11719|Praha 1|8|CZE||||||");
			writer.WriteLine("@100||5|GE Money Bank, a.s.|Praha|AGBA||0600|AGBACZPP|Praha||1422|1|Vyskočilova|14028|Praha 4|1a|CZE||||||");
			writer.WriteLine("@100||5|HSBC Bank plc - pobočka Praha|Praha|MIDL||8150|MIDLCZPP|Praha||1028|1|V Celnici|11721|Praha 1|10|CZE||||||");
			writer.WriteLine("@100||5|HVB Bank Czech Republic a. s.|Praha|CABV||2700|BACXCZPP|Praha||2090|1|Nám. Republiky|11000|Praha 1|3A|CZE||||||");
			writer.WriteLine("@100||5|HYPO stavební spořitelna, a.s.|Praha|HYPS||7950|NEMÁ KÓD|Praha||870|1|Senovážné nám.|11000|Praha 1|27|CZE||||||");
			writer.WriteLine("@100||5|Hypoteční banka, a.s.|Praha|CMHB||2100|NEMÁ KÓD|Praha||409|1|Budějovická|14000|Praha 4|1|CZE||||||");
			writer.WriteLine("@100||5|IC Banka, a.s.|Praha|ICBN||6100|BAPPCZPP|Praha||740|1|Palackého|11121|Praha 1|1|CZE||||||");
			writer.WriteLine("@100||5|ING Bank N.V.|Praha|INGB||3500|INGBCZPP|Praha||334|1|Nádražní|15000|Praha 5|25|CZE||||||");
			writer.WriteLine("@100||5|J & T BANKA, a. s.|Praha|JTBP||5800|JTBPCZPP|Praha||297|1|Pobřežní|18600|Praha 8|14|CZE||||||");
			writer.WriteLine("@100||5|Komerční banka, a.s.|Praha|KOMB||0100|KOMBCZPP|Praha||969|1|Na Příkopě|11407|Praha 1|33|CZE||||||");
			writer.WriteLine("@100||5|Modrá pyramida stavební spořitelna, a.s.|Praha|VSPO||7990|NEMÁ KÓD|Praha||222|1|Bělehradská|12021|Praha 2|128|CZE||||||");
			writer.WriteLine("@100||5|Oberbank AG  pobočka Česká republika |České Budějovice|SMWR||8040|OBKLCZ2X|České Budějovice||6|1|nám. Přemysla Otakara II|37001|České Budějovice|3|CZE||||||");
			writer.WriteLine("@100||5|PPF banka, a.s.|Praha|PMBA||6000|PMBPCZPP|Praha||1702|1|Na Strži|14062|Praha 4|65|CZE||||||");
			writer.WriteLine("@100||5|PRIVAT BANK AG der Raiffeisenlandesbank Oberösterreich, |Praha|RZOO||8200|NEMÁ KÓD|Praha||709|1|Dlouhá|11000|Praha 1|26|CZE||||||");
			writer.WriteLine("@100||5|Raiffeisenbank, a.s.|Praha|RZBC||5500|RZBCCZPP|Praha||2006|1|Olbrachtova|14021|Praha 4|9|CZE||||||");
			writer.WriteLine("@100||5|Raiffeisenbank im Stiftland eG, pobočka Cheb, odštěpný závod|Cheb|DRBW||8030|NEMÁ KÓD|Cheb||602|1|Kubelíkova|35002|Cheb|4|CZE||||||");
			writer.WriteLine("@100||5|Raiffeisen stavební spořitelna, a. s.|Praha|ARSS||7950|NEMÁ KÓD|Praha||2747|1|Koněvova|13045|Praha 3|99|CZE||||||");
			writer.WriteLine("@100||5|Stavební spořitelna České spořitelny, a. s.|Praha|CSST||8060|NEMÁ KÓD|Praha||1632|1|Vinohradská|13011|Praha 3|180|CZE||||||");
			writer.WriteLine("@100||5|Volksbank CZ, a. s.|Praha|VBOE||6800|VBOECZ2X|Praha||13|1|Lazarská|12000|Praha 2|8|CZE||||||");
			writer.WriteLine("@100||5|Všeobecná úvěrová banka, a.s. - pobočka Praha|Praha|SUBACA||6700|SUBACZPP|Praha||620|1|Pobřežní|18600|Praha 8|3|CZE||||||");
			writer.WriteLine("@100||5|Waldvierteler Sparkasse von 1842|Jindřichův Hradec|SPWT||7940|SPWTCZ21|Jindřichův Hradec||126|1|Klášterská|37701|Jindřichův Hradec|2|CZE||||||");
			writer.WriteLine("@100||5|Wüstenrot hypoteční banka, a.s.|Praha|WUEH||7980|NEMÁ KÓD|Praha||602|1|náměstí Kinských|15000|Praha 5|2|CZE||||||");
			writer.WriteLine("@100||5|Wüstenrot - stavební spořitelna, a.s.|Praha|SSWT||7970|NEMÁ KÓD|Praha||477|1|Janáčkovo nábř.|15021|Praha 5|41|CZE||||||");
			writer.WriteLine("@100||5|Živnostenská banka, a.s.|Praha|ZIBA||2700|BACXCZPP|Praha||858|1|Na Příkopě|11380|Praha 1|20|CZE||||||");
			writer.WriteLine(utvarImResult);
			writer.WriteLine("@107||Divize-001|DIV-001||||");
			writer.WriteLine("@102||Účetní Zdroj-001|ZDR-001|110|||||");
			writer.WriteLine("@102||Středisko-001|S-001|100||Divize-001|||");
			writer.WriteLine("@102||Činnost-001|CIN-001|101|||||");
			writer.WriteLine("@102||Zakázka-001|ZAK-001|102|||||");
			writer.WriteLine("@102||Služba-019|SLZ-019|121|||||");
			writer.WriteLine("@102||Služba-020|SLZ-020|121|||||");
			writer.WriteLine("@103||1040|4||4|2|1|1|1|1|0|1|1|0|AUTORI|AUTORI||||");
			writer.WriteLine("@103||1050|5||4|4|1|1|1|1|1000|1|1|0|AUTORI_SRAZ|AUTORI_SRAZ||||");
			writer.WriteLine("@103||2640|4||28|1|1|1|0|1|0|0|1|0|NAHRADA_DOV|NAHRADA_DOV||||");
		}

		private static void CreateDirectory(string targetPath)
		{
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
		}

		private static void CopyFileToDirectory(string sourceFile, string targetPath)
		{
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			string fileName = System.IO.Path.GetFileName(sourceFile);

			string destFile = System.IO.Path.Combine(targetPath, fileName);

			System.IO.File.Copy(sourceFile, destFile, true);
		}

		private static void CopyDirFilesToDirectory(string sourcePath, string targetPath)
		{
			if (!System.IO.Directory.Exists(targetPath))
			{
				System.IO.Directory.CreateDirectory(targetPath);
			}
			if (System.IO.Directory.Exists(sourcePath))
			{
				string[] files = System.IO.Directory.GetFiles(sourcePath);

				string fileName = "";
				string destFile = "";

				// Copy the files and overwrite destination files if they already exist.
				foreach (string s in files)
				{
					// Use static Path methods to extract only the file name from the path.
					fileName = System.IO.Path.GetFileName(s);

					destFile = System.IO.Path.Combine(targetPath, fileName);

					System.IO.File.Copy(s, destFile, true);
				}
			}
			else
			{
				Console.WriteLine("Source path does not exist!");
			}
		}

		private static void CreateTestDirTree(TestInitParams versionFolders)
		{
			CreateDirectory(versionFolders.PathTestsNodeFolder);

			CreateDirectory(versionFolders.PathTestsExecFolder);
			CreateDirectory(versionFolders.PathTestsDataFolder);
			CreateDirectory(versionFolders.PathArchsDataFolder);
			CreateDirectory(versionFolders.PathTiskyDataFolder);
			CreateDirectory(versionFolders.PathEmptyDataFolder);
			CreateDirectory(versionFolders.PathImportTxtFolder);
			CreateDirectory(versionFolders.PathResultTxtFolder);
		}

	}
}
