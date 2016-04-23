using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataVyuc
	{
		public string RokMesPoc { get; set; }
		public string ProcesTyp { get; set; }
		public string ArchivRun { get; set; }
		public string ArchivNaz { get; set; }
		public string ReportRun { get; set; }
		public ImportDataVyuc()
		{
			RokMesPoc = "";
			ProcesTyp = "";
			ArchivRun = "";
			ArchivNaz = "";
			ReportRun = "";
		}

		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesPoc);
		}
		public long RokPocitany()
		{
			return UtilsTable.RokNumber(RokMesPoc);
		}
		public long MesPocitany()
		{
			return UtilsTable.MesNumber(RokMesPoc);
		}
		public long IsArchivRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(ArchivRun);
			return (nDataNumb);
		}
		public long IsReportRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(ReportRun);
			return (nDataNumb);
		}
	}
}

