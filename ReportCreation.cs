﻿using DeliveryApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
	public partial class ReportCreation : Form
	{
		public DateTime StartReportDate { get; private set; }
		public DateTime EndReportDate { get; private set; }
		public string ReportDistrict { get; private set; }

		private List<string> Districts = new List<string>();
		
		public ReportCreation(List<string> districts)
		{
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

			string rawDeliveryDate = $"{timePickerFirstDeliveryDate.Text} {cbReportTimeHours.SelectedItem}:{cbReportTimeMinutes.SelectedItem}:{cbReportTimeSeconds.SelectedItem}";
			DateTime startReportDate;
			if (!DateTime.TryParse(rawDeliveryDate, out startReportDate))
			{
				timePickerFirstDeliveryDate.Value = DateTime.Today;
				hasError = true;
			}
			else if (startReportDate > DateTime.Now)
			{
				timePickerFirstDeliveryDate.Value = DateTime.Today;
				hasError = true;
			}

			if (hasError) return;
			else hasError = false;

			// calculate report timespan
			DateTime endReportDate = startReportDate.AddMinutes(30);
			if (endReportDate > DateTime.Now) endReportDate = DateTime.Now;

			StartReportDate = startReportDate;
			EndReportDate = endReportDate;
			ReportDistrict = cbReportDistrict.SelectedItem.ToString();
		}
	}
}
