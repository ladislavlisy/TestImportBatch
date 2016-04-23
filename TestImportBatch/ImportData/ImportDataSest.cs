using System;
using System.Text;
using System.IO;

namespace TestImportBatch
{
	public class ImportDataSest
	{
		public string RokMesPoc { get; set; }
		public string RokMesVOd { get; set; }
		public string RokMesVDo { get; set; }
		public string SestavMes { get; set; }
		public string SestavRok { get; set; }
		public string SestavExc { get; set; }
		public string SestavInc { get; set; }
		public ImportDataSest()
		{
			RokMesPoc = "";
			RokMesVOd = "";
			RokMesVDo = "";
			SestavMes = "";
			SestavRok = "";
			SestavExc = "";
			SestavInc = "";
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
		public long RokSestOd()
		{
			return UtilsTable.RokNumber(RokMesVOd);
		}
		public long MesSestOd()
		{
			return UtilsTable.MesNumber(RokMesVOd);
		}
		public long RokSestDo()
		{
			return UtilsTable.RokNumber(RokMesVDo);
		}
		public long MesSestDo()
		{
			return UtilsTable.MesNumber(RokMesVDo);
		}
		public long IsSestavyMesRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(SestavMes);
			return (nDataNumb);
		}
		public long IsSestavyRokRun()
		{
			long nDataNumb = UtilsTable.Int32ParseNumber(SestavRok);
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
			ImportUtils.AppendField(builder, SestavInc);
			ImportUtils.AppendField(builder, SestavExc);

			string vetaImResult = builder.ToString();
			writer.WriteLine(vetaImResult);
		}
	}
}

