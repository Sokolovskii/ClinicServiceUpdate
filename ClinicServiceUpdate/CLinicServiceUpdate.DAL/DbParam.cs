using System;
using System.Collections.Generic;
using System.Text;

namespace CLinicServiceUpdate.DAL
{
	/// <summary>
	/// Класс, описывающий пару ключ-значение для параметров процедур sql
	/// </summary>
	class DbParam
	{
		public string Key { get; }

		public object Value { get; }

		public DbParam(string key, object value)
		{
			Key = key;
			Value = value;
		}
	}
}
