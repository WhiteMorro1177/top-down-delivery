using DeliveryApp.helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DeliveryApp
{
	public partial class ReportCreation : Form
	{
		private Logger logger;
		public DateTime StartReportDate { get; private set; }
		public DateTime EndReportDate { get; private set; }
		public string ReportDistrict { get; private set; }

		private List<string> Districts = new List<string>();
		
		public ReportCreation(List<string> districts)
		{
			logger = Logger.GetLogger;
			Districts = districts;

			InitializeComponent();

			cbReportDistrict.Items.AddRange(districts.ToArray());

			timePickerFirstDeliveryDate.Value = DateTime.Today;

			cbReportTimeHours.SelectedIndex = 0;
			cbReportTimeMinutes.SelectedIndex = 0;
			cbReportTimeSeconds.SelectedIndex = 0;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			cbReportDistrict.Text = string.Empty;
			timePickerFirstDeliveryDate.Value = DateTime.Today;

			cbReportTimeHours.SelectedIndex = 0;
			cbReportTimeMinutes.SelectedIndex = 0;
			cbReportTimeSeconds.SelectedIndex = 0;

			logger.Log(Logger.LogLevel.INFO, GetType().FullName, "Time fields reseted");
		}

		private void btnCreateReport_Click(object sender, EventArgs e)
		{
			bool hasError = false;

			// check input fields
			if (!Districts.Contains(cbReportDistrict.SelectedItem))
			{
				cbReportDistrict.Text = string.Empty;
				hasError = true;
			}

			// string rawDeliveryDate = $"{timePickerFirstDeliveryDate.Text} {cbReportTimeHours.SelectedItem}:{cbReportTimeMinutes.SelectedItem}:{cbReportTimeSeconds.SelectedItem}";
			string rawDeliveryDate = string.Join("-", timePickerFirstDeliveryDate.Text.Split('.').Reverse());
			string rawDeliveryTime = $"{cbReportTimeHours.SelectedItem}:{cbReportTimeMinutes.SelectedItem}:{cbReportTimeSeconds.SelectedItem}";
			string rawDeliveryDateTime = DateTimeFormatter.FormatToStringLong(DateTimeFormatter.FormatToDateTime(rawDeliveryDate, rawDeliveryTime));


			DateTime startReportDate;
			if (!DateTime.TryParse(rawDeliveryDateTime, out startReportDate))
			{
				timePickerFirstDeliveryDate.Value = DateTime.Today;
				hasError = true;
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Unexpected token in delivery date");
			}
			else if (startReportDate > DateTime.Now)
			{
				timePickerFirstDeliveryDate.Value = DateTime.Today;
				hasError = true;
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Report date bigger than today date");
			}

			if (hasError) return;

			// calculate report timespan
			DateTime endReportDate = startReportDate.AddMinutes(30);
			if (endReportDate > DateTime.Now) endReportDate = DateTime.Now;

			StartReportDate = startReportDate;
			EndReportDate = endReportDate;
			ReportDistrict = cbReportDistrict.SelectedItem.ToString();
			logger.Log(Logger.LogLevel.INFO, GetType().FullName, "All values extracted");
			Close();
		}
	}
}
