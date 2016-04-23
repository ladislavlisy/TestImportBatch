using System;
using System.IO;
using System.Text;

namespace TestImportBatch
{
	public class JsonDataSest
	{
		public string RokMesicZaznamu { get; set; }
		public string VytvoritRokMesicOd { get; set; }
		public string VytvoritRokMesicDo { get; set; }
		public string VytvoritSestavyMesicni { get; set; }
		public string VytvoritSestavyRocni { get; set; }
		public string SestavyNevytvaret { get; set; }
		public string SestavyVytvaret { get; set; }
		public JsonDataSest()
		{
			RokMesicZaznamu = "";
			VytvoritRokMesicOd = "";
			VytvoritRokMesicDo = "";
			VytvoritSestavyMesicni = "";
			VytvoritSestavyRocni = "";
			SestavyNevytvaret = "";
			SestavyVytvaret = "";
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
		public long RokSestOd()
		{
			return UtilsTable.RokNumber(VytvoritRokMesicOd);
		}
		public long MesSestOd()
		{
			return UtilsTable.MesNumber(VytvoritRokMesicOd);
		}
		public long RokSestDo()
		{
			return UtilsTable.RokNumber(VytvoritRokMesicDo);
		}
		public long MesSestDo()
		{
			return UtilsTable.MesNumber(VytvoritRokMesicDo);
		}
		public long IsSestavyMesRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(VytvoritSestavyMesicni);
			return (nDataNumb);
		}
		public long IsSestavyRokRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(VytvoritSestavyRocni);
			return (nDataNumb);
		}

		public void CreateImportRecord154(TextWriter writer)
		{
			StringBuilder builder = ImportUtils.CreateLine(154);

			ImportUtils.AppendField(builder, "1");
			ImportUtils.AppendField(builder, RokSestOd());
			ImportUtils.AppendField(builder, MesSestOd());
			ImportUtils.AppendField(builder, RokSestDo());
			ImportUtils.AppendField(builder, MesSestDo());
			ImportUtils.AppendField(builder, IsSestavyMesRun());
			ImportUtils.AppendField(builder, IsSestavyRokRun());
			ImportUtils.AppendField(builder, SestavyVytvaret);
			ImportUtils.AppendField(builder, SestavyNevytvaret);

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}
	}
}

