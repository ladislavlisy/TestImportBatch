using System;

namespace TestImportBatch
{
	public class JsonDataVyuc
	{
		public string RokMesicZaznamu { get; set; }
		public string ProcesTyp { get; set; }
		public string ProvestArchivaci { get; set; }
		public string ArchivNazev { get; set; }
		public string VytvoreniSestav { get; set; }
		public JsonDataVyuc()
		{
			RokMesicZaznamu = "";
			ProcesTyp = "";
			ProvestArchivaci = "";
			ArchivNazev = "";
			VytvoreniSestav = "";
		}

		public long RokMesPocitany()
		{
			return UtilsTable.RokMes(RokMesicZaznamu);
		}
		public long RokPocitany()
		{
			return UtilsTable.RokNumber(RokMesicZaznamu);
		}
		public long MesPocitany()
		{
			return UtilsTable.MesNumber(RokMesicZaznamu);
		}
		public long IsArchivRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(ProvestArchivaci);
			return (nDataNumb);
		}
		public long IsReportRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(VytvoreniSestav);
			return (nDataNumb);
		}
	}
}

