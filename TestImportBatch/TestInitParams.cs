using System;

namespace TestImportBatch
{
	public class TestInitParams
	{
		const string ADDS_TESTSEXEC_FOLDER = "TESTVERZE";
		const string ADDS_TESTSDATA_FOLDER = "TEST_DATA";
		const string ADDS_ARCHSDATA_FOLDER = "ARCHIV";
		const string ADDS_TISKSDATA_FOLDER = "TISKY";
		const string ADDS_EMPTYDATA_FOLDER = "PRAZDNA";
		const string ADDS_IMPORTTXT_FOLDER = "IMPORTY";
		const string ADDS_RESULTTXT_FOLDER = "VYSLEDKY";

		public const string PROVIDER_ACCESS = "1";
		public const string PROVIDER_MS_SQL = "10";
		public const string DATABASE_EXLOCK = "1";
		public const string DATABASE_SHARED = "0";
		public const string DATABASE_OWNRPW = "D84A56202ED0ED46440DDDCD5B5C701C";
		public const string DATABASE_USERPW = "7355F5E53BC55173";
		public const string MSSQLSER_OWNRPW = "DA0E8433E89531A05C0F38DFCAF1ACCB";
		public const string MSSQLSER_USERPW = "55FCC22DE2E2049B00367EAA821B6B73";
		public const string MSSQLSERVERNAME = ".\\SQLEXPRESS2014";

		public string VersFolder { get; private set; }
		public string KonfigNode { get; private set; }
		public string PathTestsNodeFolder { get; private set; }
		public string PathTestsExecFolder { get; private set; }
		public string PathTestsDataFolder { get; private set; }
		public string PathArchsDataFolder { get; private set; }
		public string PathTiskyDataFolder { get; private set; }
		public string PathEmptyDataFolder { get; private set; }
		public string PathImportTxtFolder { get; private set; }
		public string PathResultTxtFolder { get; private set; }
		public string TestSuiteImportFile { get; private set; }
		public TestInitParams()
		{
			VersFolder = "";
			KonfigNode = "";
			PathTestsNodeFolder = "";
			PathTestsExecFolder = "";
			PathTestsDataFolder = "";
			PathArchsDataFolder = "";
			PathTiskyDataFolder = "";
			PathEmptyDataFolder = "";
			PathImportTxtFolder = "";
			PathResultTxtFolder = "";
			TestSuiteImportFile = "";
		}

		public TestInitParams(string vVersionApps, string vVersionData)
		{
			SetVersFolder(vVersionApps);
			SetKonfigNode(vVersionData);
			PathTestsNodeFolder = "";
			PathTestsExecFolder = "";
			PathTestsDataFolder = "";
			PathArchsDataFolder = "";
			PathTiskyDataFolder = "";
			PathEmptyDataFolder = "";
			PathImportTxtFolder = "";
			PathResultTxtFolder = "";
			TestSuiteImportFile = "";
		}

		public void NastavTestsFolders(string appExecutableFolder)
		{
			SetPathTestsNodeFolder(appExecutableFolder, VersFolder);

			SetPathTestsExecFolder(PathTestsNodeFolder, ADDS_TESTSEXEC_FOLDER);
			SetPathTestsDataFolder(PathTestsNodeFolder, ADDS_TESTSDATA_FOLDER);
			SetPathArchsDataFolder(PathTestsNodeFolder, ADDS_ARCHSDATA_FOLDER);
			SetPathTiskyDataFolder(PathTestsNodeFolder, ADDS_TISKSDATA_FOLDER);
			SetPathEmptyDataFolder(PathTestsNodeFolder, ADDS_EMPTYDATA_FOLDER);
			SetPathImportTxtFolder(PathTestsNodeFolder, ADDS_IMPORTTXT_FOLDER);
			SetPathResultTxtFolder(PathTestsNodeFolder, ADDS_RESULTTXT_FOLDER);
		}

		public void SetPathTestsNodeFolder(string parentFolder, string partToAdd) { PathTestsNodeFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathTestsExecFolder(string parentFolder, string partToAdd) { PathTestsExecFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathTestsDataFolder(string parentFolder, string partToAdd) { PathTestsDataFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathArchsDataFolder(string parentFolder, string partToAdd) { PathArchsDataFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathTiskyDataFolder(string parentFolder, string partToAdd) { PathTiskyDataFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathEmptyDataFolder(string parentFolder, string partToAdd) { PathEmptyDataFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathImportTxtFolder(string parentFolder, string partToAdd) { PathImportTxtFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetPathResultTxtFolder(string parentFolder, string partToAdd) { PathResultTxtFolder = System.IO.Path.Combine(parentFolder, partToAdd); }
		public void SetTestSuiteImportFile(string parentFolder, string partToAdd) { TestSuiteImportFile = System.IO.Path.Combine(parentFolder, partToAdd); }

		public string ExtendPathTestsNodeFolder(string partToAdd) { return System.IO.Path.Combine(PathTestsNodeFolder, partToAdd); }
		public string ExtendPathTestsExecFolder(string partToAdd) { return System.IO.Path.Combine(PathTestsExecFolder, partToAdd); }
		public string ExtendPathTestsDataFolder(string partToAdd) { return System.IO.Path.Combine(PathTestsDataFolder, partToAdd); }
		public string ExtendPathArchsDataFolder(string partToAdd) { return System.IO.Path.Combine(PathArchsDataFolder, partToAdd); }
		public string ExtendPathTiskyDataFolder(string partToAdd) { return System.IO.Path.Combine(PathTiskyDataFolder, partToAdd); }
		public string ExtendPathEmptyDataFolder(string partToAdd) { return System.IO.Path.Combine(PathEmptyDataFolder, partToAdd); }
		public string ExtendPathImportTxtFolder(string partToAdd) { return System.IO.Path.Combine(PathImportTxtFolder, partToAdd); }
		public string ExtendPathResultTxtFolder(string partToAdd) { return System.IO.Path.Combine(PathResultTxtFolder, partToAdd); }
		public string ExtendTestSuiteImportFile(string partToAdd) { return System.IO.Path.Combine(TestSuiteImportFile, partToAdd); }

		internal void SetVersFolder(string versionDir)
		{
			VersFolder = versionDir;
		}

		internal void SetKonfigNode(string konfigNode)
		{
			KonfigNode = konfigNode;
		}

		internal string PathTestsSystemDB()
		{
			return PathTestsDataFolder + "\\okmzdyw.mdw";
		}

        private static void CreateDirectory(string targetPath)
        {
            if (!System.IO.Directory.Exists(targetPath))
            {
                System.IO.Directory.CreateDirectory(targetPath);
            }
        }

        public void CreateTestDirTree()
        {
            CreateDirectory(PathTestsNodeFolder);

            CreateDirectory(PathTestsExecFolder);
            CreateDirectory(PathTestsDataFolder);
            CreateDirectory(PathArchsDataFolder);
            CreateDirectory(PathTiskyDataFolder);
            CreateDirectory(PathEmptyDataFolder);
            CreateDirectory(PathImportTxtFolder);
            CreateDirectory(PathResultTxtFolder);
        }


    }
}

