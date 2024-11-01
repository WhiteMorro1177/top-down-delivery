using DeliveryApp.DTO;
using DeliveryApp.helper;
using System;
using System.IO;

namespace DeliveryApp
{
	internal class Logger
	{
		private static Logger _instance;

		public static Logger GetLogger
		{
			get
			{
				if (_instance == null) _instance = new Logger();
				return _instance;
			}
		}

		public enum LogLevel
		{
			INFO = 0,
			WARNING = 1,
			DEBUG = 2,
			ERROR = 3,
		}

		private Logger() { }

		public void Log(LogLevel level, string className, string message)
		{
			string today = DateTimeFormatter.FormatToStringShort(DateTime.Now);
			string logfilePath = $"{Config.GetConfig.LogsDirectory}log_{today}.txt";
			if (!File.Exists(logfilePath))
			{
				FileStream fs = File.Create(logfilePath);
				fs.Close();
			}

			File.AppendAllText(logfilePath, $"[{DateTimeFormatter.FormatToStringShort(DateTime.Now)}] - Log Level: {level} - Module: {className} - Message: {message}\n");
		}
	}
}
