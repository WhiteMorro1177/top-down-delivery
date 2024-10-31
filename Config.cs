using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryApp.DTO
{
	internal class Config
	{
		private static Config _instance;

		private readonly string _dataDirectory;
		private readonly string _backupDirectory;
		private readonly string _reportsDirectory;
		private readonly string _logsDirectory;


		public string DataDirectory { get { return _dataDirectory; } }
		public string BackupDirectory { get { return _backupDirectory; } }
		public string ReportsDirectory { get { return _reportsDirectory; } }
		public string LogsDirectory { get { return _logsDirectory; } }


		public static Config GetConfig
		{
			get
			{
				if (_instance == null) _instance = new Config();
				return _instance;
			}
		} 

		private Config()
		{
			_dataDirectory = "C:\\Users\\jackf\\source\\repos\\DeliveryApp\\DeliveryApp\\data\\";
			_backupDirectory = "C:\\Users\\jackf\\source\\repos\\DeliveryApp\\DeliveryApp\\data\\";
			_reportsDirectory = "C:\\Users\\jackf\\source\\repos\\DeliveryApp\\DeliveryApp\\reports\\";
			_logsDirectory = "C:\\Users\\jackf\\source\\repos\\DeliveryApp\\DeliveryApp\\reports\\";
		}
	}
}
