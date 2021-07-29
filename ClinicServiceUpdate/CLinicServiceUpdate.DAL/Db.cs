using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace CLinicServiceUpdate.DAL
{
	/// <summary>
	/// Класс, содержащий логику исполнения sql запросов в ADO.NET
	/// </summary>
	class Db
	{
		/// <summary>
		/// Строка подключения к БД
		/// </summary>
		private readonly string connectionString = "Server=\\SQLEXPRESS;Database=ClinicService;Trusted_Connection=True;";
		
		/// <summary>
		/// .ctor
		/// </summary>
		public Db() { }

		/// <summary>
		/// Обобщенный метод получения списка из бд
		/// </summary>
		public List<T> GetList<T>(string storedProcedure, Func<IDataReader, T> readerFunc, params DbParam[] args)
		{
			var result = new List<T>();

			using (var connection = new SqlConnection(connectionString))
			{
				var command = OpenConnection(storedProcedure, connection);

				foreach(var dbParam in args)
				{
					command.Parameters.AddWithValue(dbParam.Key, dbParam.Value);
				}

				var reader = command.ExecuteReader();

				while (reader.Read())
				{
					result.Add(readerFunc(reader));
				}

				return result;
			}
		}

		/// <summary>
		/// Обобщенный метод получения одной записи из бд
		/// </summary>
		public T GetItem<T>(string storedProcedure, Func<IDataReader, T> readerFunc, params DbParam[] args)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				var command = OpenConnection(storedProcedure, connection);

				foreach (var dbParam in args)
				{
					command.Parameters.AddWithValue(dbParam.Key, dbParam.Value);
				}

				var reader = command.ExecuteReader();
				if (reader.HasRows && reader.Read())
					return readerFunc(reader);

				return default;
			}
		}

		/// <summary>
		/// Обобщенный метод для добавления записей в БД
		/// </summary>
		public void ExecuteNonQuery(string storedProcedure, params DbParam[] args)
		{
			using (var connection = new SqlConnection(connectionString))
			{
				var command = OpenConnection(storedProcedure, connection);

				foreach (var dbParam in args)
				{
					command.Parameters.AddWithValue(dbParam.Key, dbParam.Value);
				}

				var result = command.ExecuteNonQuery();
			}
		}

		/// <summary>
		/// Открывает соединение и возвращает command
		/// </summary>
		private static SqlCommand OpenConnection(string sqlExpression, SqlConnection connection)
		{
			connection.Open();
			var command = new SqlCommand(sqlExpression, connection);
			command.CommandType = CommandType.StoredProcedure;
			return command;
		}

	}
}
