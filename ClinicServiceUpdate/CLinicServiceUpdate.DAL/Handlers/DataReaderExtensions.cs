using System;
using System.Data;

namespace ClinicServiceUpdate.DAL.Handlers
{
	public static class DataReaderExtensions
	{
		/// <summary>
		/// Конвертирует Object из ридера в массив байт и возвращает его
		/// </summary>
		/// <param name="reader">ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		public static byte[] GetBytes(this IDataReader reader, string name)
		{
			return (byte[])(reader[name]);
		}

		/// <summary>
		/// Конвертирует Object из ридера в boolean и возвращает его
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		public static bool GetBoolean(this IDataReader reader, string name)
		{
			return Convert.ToBoolean(reader[name]);
		}

		/// <summary>
		/// Конвертирует Object из ридера в DateTime и возвращает его
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя слолбца таблицы, которую прочитал ридер</param>
		public static DateTime GetDateTime(this IDataReader reader, string name)
		{
			return Convert.ToDateTime(reader[name]);
		}

		/// <summary>
		/// Конвертирует Object из ридера в DateTime и возвращает значение Date 
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		public static DateTime GetDate(this IDataReader reader, string name)
		{
			return Convert.ToDateTime(reader[name]).Date;
		}

		/// <summary>
		/// Конвертирует Object из ридера в TimeSpan и возвращает его
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		/// <returns></returns>
		public static TimeSpan GetTime(this IDataReader reader, string name)
		{
			return TimeSpan.Parse(GetString(reader, name));
		}

		/// <summary>
		/// Проверяет Object з ридера на соответствие типу DBNull и если оно
		/// отрицательно, то преобразует Object в int и возвращает, если положительно, то возвращает 0
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		/// <returns></returns>
		public static int GetIntOrZero(this IDataReader reader, string name)
		{
			return !DBNull.Value.Equals(reader[name]) ? Convert.ToInt32(reader[name]) : 0;
		}

		/// <summary>
		/// Преобразует Object из ридера в string и возвращает его
		/// </summary>
		/// <param name="reader">Ридер</param>
		/// <param name="name">Имя столбца таблицы, которую прочитал ридер</param>
		/// <returns></returns>
		public static string GetString(this IDataReader reader, string name)
		{
			return Convert.ToString(reader[name]);
		}
	}
}
