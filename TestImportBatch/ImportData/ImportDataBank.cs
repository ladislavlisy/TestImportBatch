using System;

namespace TestImportBatch
{
	public class ImportDataBank
	{
		public string VypBkUcet { get; set; }
		public string VypBkBank { get; set; }
		public string VypBkKSym { get; set; }
		public string VypBkVSym { get; set; }
		public string VypBkSSym { get; set; }
		public ImportDataBank()
		{
			VypBkUcet = "";
			VypBkBank = "";
			VypBkKSym = "";
			VypBkVSym = "";
			VypBkSSym = "";
		}
	}
}

