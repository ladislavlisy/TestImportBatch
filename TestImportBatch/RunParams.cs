using System;
using System.IO;
using System.Xml;

namespace TestImportBatch
{
	public class RunParams
	{
		public const string TEST_OSOBCISLO_DAVKA = "00001-POM";
		public const string TEST_OSOBCISLO_POMER = "01-PPOM";
		public const string TEST_OSOBUTVAR_DAVKA = "UTVAR-001";
		public const string TEST_DANEPRIJMY_ROK1 = "2014";
		public const string TEST_DANEPRIJMY_ROK2 = "2015";

		public const string EMPTY_LIST_SEST = "";
		public const int ACCESS_ARCHIVACE_RUN = 1;
		public const int MS_SQL_ARCHIVACE_RUN = 0;

		public const string fileTestsKonfigFXML = "test_konfig.xml";

		public string AppExecutableFolder { get; private set; } 
		public string PathTestsKonfigFXML { get; private set; } 

		public TestInitParams OldTestFolders { get; private set; } 
		public TestInitParams NewTestFolders { get; private set; } 

		public RunParams ()
		{
			OldTestFolders = null;
			NewTestFolders = null;

			AppExecutableFolder = "";
			PathTestsKonfigFXML = "";
		}

		private string ExecutableAppFolder(string[] args)
		{
			string appExecutableFileNm = args[0];

			return System.IO.Path.GetDirectoryName(appExecutableFileNm);
		}

		public void SetDirectoryVariables(string[] args)
		{
			AppExecutableFolder = ExecutableAppFolder(args);

			PathTestsKonfigFXML = System.IO.Path.Combine(AppExecutableFolder, fileTestsKonfigFXML);

			OldTestFolders = new TestInitParams("OLD_VERSION", "OLD_TEST_DATA");
			OldTestFolders.NastavTestsFolders(AppExecutableFolder);

			NewTestFolders = new TestInitParams("NEW_VERSION", "NEW_TEST_DATA");
			NewTestFolders.NastavTestsFolders(AppExecutableFolder);
		}

        public void CreateTestDirTree()
        {
            OldTestFolders.CreateTestDirTree();
            NewTestFolders.CreateTestDirTree();
        }

        public void CreateKonfigFileAccess()
		{
			using (TextWriter writer = File.CreateText(PathTestsKonfigFXML))
			{
				XmlWriter xmlBuilder = XmlWriter.Create(writer);

				xmlBuilder.WriteStartDocument();
				xmlBuilder.WriteStartElement("OKmzdy_pro_Windows");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Shortcut Desktop", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Archiv Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Parent Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Shortcut Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskovy Folder", "value", "");
				xmlBuilder.WriteStartElement("DATA");
				xmlBuilder.WriteStartElement("konfigurace");
				XmlKonfigBuilder.WriteAttribute(xmlBuilder, "name", OldTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database User", "value", "okmzdy");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Psw", "value", TestInitParams.DATABASE_USERPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner", "value", "oksystem");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner Psw", "value", TestInitParams.DATABASE_OWNRPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Archiv", "value", OldTestFolders.PathArchsDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskove Soubory", "value", OldTestFolders.PathTiskyDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", OldTestFolders.PathTestsDataFolder + "\\okmzdyw.mdb");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", OldTestFolders.PathTestsSystemDB());
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Server", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database DSN", "value", OldTestFolders.KonfigNode);

				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Provider", "value", TestInitParams.PROVIDER_ACCESS);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Exclusive", "value", TestInitParams.DATABASE_EXLOCK);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB Shared", "value", TestInitParams.DATABASE_SHARED);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tisknout Bitmapy", "value", "0");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Backup", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdExp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdImp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ODBC Driver Dbf", "value", "dBASE IV;");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ExportUM uvozovky", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database HRLink", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "remove_prac", "value", "");
				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteStartElement("konfigurace");
				XmlKonfigBuilder.WriteAttribute(xmlBuilder, "name", NewTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database User", "value", "okmzdy");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Psw", "value", TestInitParams.DATABASE_USERPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner", "value", "oksystem");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner Psw", "value", TestInitParams.DATABASE_OWNRPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Archiv", "value", NewTestFolders.PathArchsDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskove Soubory", "value", NewTestFolders.PathTiskyDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", NewTestFolders.PathTestsDataFolder + "\\okmzdyw.mdb");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", NewTestFolders.PathTestsSystemDB());
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Server", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database DSN", "value", NewTestFolders.KonfigNode);

				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Provider", "value", TestInitParams.PROVIDER_ACCESS);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Exclusive", "value", TestInitParams.DATABASE_EXLOCK);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB Shared", "value", TestInitParams.DATABASE_SHARED);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tisknout Bitmapy", "value", "0");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Backup", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdExp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdImp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ODBC Driver Dbf", "value", "dBASE IV;");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ExportUM uvozovky", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database HRLink", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "remove_prac", "value", "");
				xmlBuilder.WriteEndElement();

				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteEndDocument();

				//Write the XML to file and close the writer.
				xmlBuilder.Flush();
				xmlBuilder.Close();
				writer.Close();
			}
		}

		public void CreateKonfigFileMsSQL()
		{
			using (TextWriter writer = File.CreateText(PathTestsKonfigFXML))
			{
				XmlWriter xmlBuilder = XmlWriter.Create(writer);

				xmlBuilder.WriteStartDocument();
				xmlBuilder.WriteStartElement("OKmzdy_pro_Windows");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Shortcut Desktop", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Archiv Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Parent Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Shortcut Folder", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskovy Folder", "value", "");
				xmlBuilder.WriteStartElement("DATA");
				xmlBuilder.WriteStartElement("konfigurace");
				XmlKonfigBuilder.WriteAttribute(xmlBuilder, "name", OldTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database User", "value", "okmzdy");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Psw", "value", TestInitParams.MSSQLSER_USERPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner", "value", "oksystem");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner Psw", "value", TestInitParams.MSSQLSER_OWNRPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Archiv", "value", OldTestFolders.PathArchsDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskove Soubory", "value", OldTestFolders.PathTiskyDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", OldTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", OldTestFolders.PathTestsSystemDB());
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Server", "value", TestInitParams.MSSQLSERVERNAME);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database DSN", "value", OldTestFolders.KonfigNode);

				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Provider", "value", TestInitParams.PROVIDER_MS_SQL);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Exclusive", "value", TestInitParams.DATABASE_EXLOCK);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB Shared", "value", TestInitParams.DATABASE_SHARED);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tisknout Bitmapy", "value", "0");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Backup", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdExp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdImp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ODBC Driver Dbf", "value", "dBASE IV;");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ExportUM uvozovky", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database HRLink", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "remove_prac", "value", "");
				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteStartElement("konfigurace");
				XmlKonfigBuilder.WriteAttribute(xmlBuilder, "name", NewTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database User", "value", "okmzdy");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Psw", "value", TestInitParams.MSSQLSER_USERPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner", "value", "oksystem");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Owner Psw", "value", TestInitParams.MSSQLSER_OWNRPW);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Archiv", "value", NewTestFolders.PathArchsDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tiskove Soubory", "value", NewTestFolders.PathTiskyDataFolder);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Name", "value", NewTestFolders.KonfigNode);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB", "value", NewTestFolders.PathTestsSystemDB());
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Server", "value", TestInitParams.MSSQLSERVERNAME);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database DSN", "value", NewTestFolders.KonfigNode);

				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Provider", "value", TestInitParams.PROVIDER_MS_SQL);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Exclusive", "value", TestInitParams.DATABASE_EXLOCK);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "SystemDB Shared", "value", TestInitParams.DATABASE_SHARED);
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Tisknout Bitmapy", "value", "0");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database Backup", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdExp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database CmdImp", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ODBC Driver Dbf", "value", "dBASE IV;");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "ExportUM uvozovky", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "Database HRLink", "value", "");
				XmlKonfigBuilder.WriteElementWith2Attributes(xmlBuilder, "polozka", "name", "remove_prac", "value", "");
				xmlBuilder.WriteEndElement();

				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteEndElement();
				xmlBuilder.WriteEndDocument();

				//Write the XML to file and close the writer.
				xmlBuilder.Flush();
				xmlBuilder.Close();
				writer.Close();
			}
		}
	}
}

