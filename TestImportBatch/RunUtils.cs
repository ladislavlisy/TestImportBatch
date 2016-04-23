using System;
using System.Linq;
using System.Reflection;
using System.Globalization;
using System.Text;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace TestImportBatch
{
	class Constants
	{
		public static char[] DEL_CHARS = new char[] { ';' };
		public static char[] TRM_CHARS = new char[] { '=', ' ', '\t' };
	}

	class UtilsTable
	{
		public static string[] GetColumns(string radka)
		{
			return radka.Split(Constants.DEL_CHARS).ToArray();
		}
		public static void ParseDataUseNames(Object obj, string[] fields, string radka)
		{
			var polozky = radka.Split(Constants.DEL_CHARS).ToArray();

			int idx = 0;

			Type _type = obj.GetType();

			foreach (var name in fields)
			{
				var propertyInfo = _type.GetProperty(name.Trim());

				if (propertyInfo != null)
				{
					propertyInfo.SetValue(obj, polozky[idx].Trim(Constants.TRM_CHARS), null);
				}
				idx++;
			}
		}

		public static void ParseDataUseIndex(Object obj, string[] fields, string radka)
		{
			var polozky = radka.Split(Constants.DEL_CHARS).ToArray();

			int idx = 0;

			Type _type = obj.GetType();

			var typeFields = _type.GetProperties(BindingFlags.Instance | BindingFlags.Public);

			foreach (var propertyInfo in typeFields)
			{
				propertyInfo.SetValue(obj, polozky[idx].Trim(Constants.TRM_CHARS), null);

				idx++;
			}
		}
		public static DateTime? Datum(string textFormat)
		{
			if (textFormat.Equals("3333-03-03"))
			{
				return null;
			}
			if (textFormat.Equals(""))
			{
				return null;
			}
			return DateTime.ParseExact(textFormat, "yyyy-MM-dd", CultureInfo.InvariantCulture);
		}
		public static DateTime? DatumTecky(string textFormat)
		{
			string errorMessage = "";

			if (textFormat.Equals("03.03.3333"))
			{
				return null;
			}
			if (textFormat.Equals(""))
			{
				return null;
			}
			DateTime? result = null;
			try
			{
				result = DateTime.ParseExact(textFormat, new string[] { "dd.MM.yyyy", "d.M.yyyy" }, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal);
			}
			catch (Exception e)
			{
				errorMessage = e.ToString ();
				result = null;
			}
			return result;
		}

		public static DateTime? Obdobi(string textFormat)
		{
			if (textFormat.Equals("3333-03"))
			{
				return null;
			}
			if (textFormat.Equals(""))
			{
				return null;
			}
			return DateTime.ParseExact(textFormat + "-01", "yyyy-MM-dd", CultureInfo.InvariantCulture);
		}

		public static decimal DecParseNumber(string numberText)
		{
			if (numberText.Trim().Equals(""))
			{
				return decimal.Zero;
			}
			return decimal.Parse(numberText.Replace('.', ','));
		}

		public static Int32 Int32ParseNumber(string numberText)
		{
			if (numberText.Trim().Equals(""))
			{
				return 0;
			}
			decimal numberValue = decimal.Parse(numberText.Replace('.', ','));
			return decimal.ToInt32(numberValue);
		}

		internal static string DatumPocetDnu(DateTime? nepr_datum_zac, DateTime? nepr_datum_kon)
		{
			int pocetDnu = 0;
			if (nepr_datum_zac.HasValue && nepr_datum_kon.HasValue)
			{
				DateTime datum_od = nepr_datum_zac.Value;
				DateTime datum_do = nepr_datum_zac.Value;
				pocetDnu = ((datum_do - datum_od).Days) + 1;
			}
			return pocetDnu.ToString("#");
		}
		public static long RokMes(string numberText)
		{
			long nRokMes = Int32ParseNumber(numberText);
			return (nRokMes);
		}
		public static long RokNumber(string numberText)
		{
			long nRokMes = Int32ParseNumber(numberText);
			return (nRokMes / 100) + 2000;
		}
		public static long MesNumber(string numberText)
		{
			long nRokMes = Int32ParseNumber(numberText);
			return (nRokMes % 100);
		}
	}

	public static class ImportUtils
	{
		public static StringBuilder CreateLine(Int16 lineCode)
		{
			StringBuilder builder = new StringBuilder("@" + lineCode.ToString() + "||");

			return builder;
		}

		public static StringBuilder AppendField(StringBuilder builder, string text)
		{
			builder.Append(text).Append("|");

			return builder;
		}

		public static StringBuilder AppendField(StringBuilder builder, long number)
		{
			builder.Append(number.ToString()).Append("|");

			return builder;
		}

		public static StringBuilder AppendEmpty(StringBuilder builder)
		{
			builder.Append("|");

			return builder;
		}

		public static IList<T> ReadTableData<T>(string fileFold, string fileName) where T : new()
		{
			string fileImport = System.IO.Path.Combine(fileFold, fileName);

			var dictTable = new List<T>();

			try
			{
				StreamReader readerFile = new StreamReader(fileImport, Encoding.GetEncoding("windows-1250"));
				if (!readerFile.EndOfStream)
				{
					string colltext = readerFile.ReadLine();
					var lineColumns = UtilsTable.GetColumns(colltext);

					while (!readerFile.EndOfStream)
					{
						string valstext = readerFile.ReadLine();
						T valueItem = new T();
						UtilsTable.ParseDataUseNames(valueItem, lineColumns, valstext);

						dictTable.Add(valueItem);
					}
				}
				readerFile.Close();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.Print(ex.Message);
			}
			return dictTable;
		}

		public static IList<T> ReadJsonData<T>(string fileFold, string fileName) where T : new()
		{
			string fileImport = System.IO.Path.Combine(fileFold, fileName);

			string testFileContent = "";

			try
			{
				StreamReader readerFile = new StreamReader(fileImport, Encoding.GetEncoding("windows-1250"));

				testFileContent = readerFile.ReadToEnd();


				readerFile.Close();
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.Print(ex.Message);
			}
			return JsonConvert.DeserializeObject<List<T>>(testFileContent);
		}

	}
}
