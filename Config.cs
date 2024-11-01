using System.IO;

namespace DeliveryApp.DTO
{
	internal class Config
	{
		private static Config _instance;

		private readonly string _dataDirectory;
		private readonly string _backupDirectory;
		private readonly string _reportsDirectory;
		private readonly string _logsDirectory;

		private readonly string _rootDirectory = "DeliveryAppDataDir";


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
			// create directories
			string rootDir = Path.Combine(Directory.GetCurrentDirectory(), _rootDirectory);
			if (!Directory.Exists(rootDir)) Directory.CreateDirectory(rootDir);
			Directory.SetCurrentDirectory(rootDir);

			CheckAndCreateDirectory("data");
			CheckAndCreateDirectory("reports");
			CheckAndCreateDirectory("logs");

			// save paths
			_dataDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
			_backupDirectory = Path.Combine(Directory.GetCurrentDirectory(), "data");
			_reportsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "reports");
			_logsDirectory = Path.Combine(Directory.GetCurrentDirectory(), "logs");
		}

		private void CheckAndCreateDirectory(string dirName)
		{
			string path = Path.Combine(Directory.GetCurrentDirectory(), dirName);
			if (!Directory.Exists(path)) Directory.CreateDirectory(path);
		}
	}
}
