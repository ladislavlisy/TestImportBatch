using System;
using System.Collections.Generic;

namespace TestImportBatch
{
	public class JsonDataParams
	{
		public string AppExecutableFolder { get; private set; } 

		public string RokMesFrom {get; private set;}
		public string RokMesUpto {get; private set;}

		public IList<JsonDataPrac> PPrac {get; private set;}
		public IList<JsonDataUPom> UPPom {get; private set;}
		public IList<JsonDataDite> DDeti {get; private set;}
		public IList<JsonDataVyuc> Vyuct {get; private set;}
		public IList<JsonDataSest> SestR {get; private set;}
		public IList<JsonDataMzda> MMzda {get; private set;}
		public IList<JsonDataNepr> MNepr {get; private set;}

		public JsonDataParams ()
		{
			this.RokMesFrom = "1501";
			this.RokMesUpto = "1512";

			this.PPrac = null;
			this.UPPom = null;
			this.DDeti = null;
			this.Vyuct = null;
			this.SestR = null;
			this.MMzda = null;
			this.MNepr = null;

		}
		private string ExecutableAppFolder(string[] args)
		{
			string appExecutableFileNm = args[0];

			return System.IO.Path.GetDirectoryName(appExecutableFileNm);
		}

		public void PrepareImportProccess(string[] args, string from, string upto)
		{
			this.RokMesFrom = from;
			this.RokMesUpto = upto;

			string appExecutableFolder = ExecutableAppFolder(args);

			string fileNameImportStart = "TestScenarStart.json";
			PPrac = ImportUtils.ReadJsonData<JsonDataPrac>(appExecutableFolder, fileNameImportStart);

			string fileNameImportUPPom = "TestScenarUPPom.json";
			UPPom = ImportUtils.ReadJsonData<JsonDataUPom>(appExecutableFolder, fileNameImportUPPom);

			string fileNameImportDDeti = "TestScenarDDeti.json";
			DDeti = ImportUtils.ReadJsonData<JsonDataDite>(appExecutableFolder, fileNameImportDDeti);

			string fileNameImportMMzda = "TestScenarMMzda.json";
			MMzda = ImportUtils.ReadJsonData<JsonDataMzda>(appExecutableFolder, fileNameImportMMzda);

			string fileNameImportMNepr = "TestScenarMNepr.json";
			MNepr = ImportUtils.ReadJsonData<JsonDataNepr>(appExecutableFolder, fileNameImportMNepr);

			string fileNameImportVyuct = "TestScenarVyuct.json";
			Vyuct = ImportUtils.ReadJsonData<JsonDataVyuc>(appExecutableFolder, fileNameImportVyuct);

			string fileNameImportSestR = "TestScenarSestR.json";
			SestR = ImportUtils.ReadJsonData<JsonDataSest>(appExecutableFolder, fileNameImportSestR);
		}

	}
}

