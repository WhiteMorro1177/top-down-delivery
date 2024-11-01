using System;
using System.Collections.Generic;
using System.Linq;

namespace DeliveryApp.helper
{
	static class DateTimeFormatter
	{
		private static string _year;
		private static string _month;
		private static string _day;

		private static string _hour;
		private static string _minute;
		private static string _second;


		public static string FormatToStringLong()
		{
			return FormatToStringLong(DateTime.Now);
		}

		public static string FormatToStringLong(DateTime dateTime)
		{
			_year = dateTime.Year.ToString();
			_month = dateTime.Month.ToString().Length == 1 ? $"0{dateTime.Month}" : dateTime.Month.ToString();
			_day = dateTime.Day.ToString().Length == 1 ? $"0{dateTime.Day}" : dateTime.Day.ToString();

			_hour = dateTime.Hour.ToString().Length == 1 ? $"0{dateTime.Hour}" : dateTime.Hour.ToString();
			_minute = dateTime.Minute.ToString().Length == 1 ? $"0{dateTime.Minute}" : dateTime.Minute.ToString();
			_second = dateTime.Second.ToString().Length == 1 ? $"0{dateTime.Second}" : dateTime.Second.ToString();

			return $"{_year}-{_month}-{_day} {_hour}:{_minute}:{_second}";
		}


		public static string FormatToStringShort()
		{
			return FormatToStringShort(DateTime.Now);
		}

		public static string FormatToStringShort(DateTime dateTime)
		{
			_year = dateTime.Year.ToString();
			_month = dateTime.Month.ToString().Length == 1 ? $"0{dateTime.Month}" : dateTime.Month.ToString();
			_day = dateTime.Day.ToString().Length == 1 ? $"0{dateTime.Day}" : dateTime.Day.ToString();

			return $"{_year}-{_month}-{_day}";
		}

		public static DateTime FormatToDateTime(string dateTimeString)
		{
			string[] dateTimeSplit = dateTimeString.Split(' ');
			return FormatToDateTime(dateTimeSplit[0], dateTimeSplit[1]);
		}
		public static DateTime FormatToDateTime(string date, string time)
		{
			List<int> dateSplit = date.Split('.', '-', '_').ToList().Select(item => int.Parse(item)).ToList();
			List<int> timeSplit = time.Split('.', '-', '_', ':').ToList().Select(item => int.Parse(item)).ToList();

			DateTime dateTime = new DateTime(dateSplit[0], dateSplit[1], dateSplit[2], timeSplit[0], timeSplit[1], timeSplit[2]);

			return dateTime;
		}
	}
}
