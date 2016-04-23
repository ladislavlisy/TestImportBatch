using System;
using System.Collections.Generic;

namespace TestImportBatch
{
	public class ImportDataParams
	{
		public IList<ImportDataPrac> PPrac {get; private set;}
		public IList<ImportDataDite> DDeti {get; private set;}
		public IList<ImportDataVyuc> Vyuct {get; private set;}
		public IList<ImportDataSest> SestR {get; private set;}
		public IList<ImportDataMzda> MMzda {get; private set;}

		public ImportDataParams ()
		{
			PPrac = null;
			DDeti = null;
			Vyuct = null;
			SestR = null;
			MMzda = null;

		}
	}
}

