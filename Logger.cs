using DeliveryApp.DTO;
using MongoDB.Bson.Serialization.Conventions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

		public void Log(string level, string message)
		{
			string today = DateTime.Today.ToShortDateString();
			string logfilePath = $"{Config.GetConfig.LogsDirectory}log_{today}.txt";
			using (StreamWriter wr = new StreamWriter(logfilePath))
			{
				wr.WriteLine($"[{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}] - Log Level: {level} - Message: {message}");
			}
		}
	}
}
