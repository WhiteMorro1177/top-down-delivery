namespace DeliveryApp
{
	partial class ReportCreation
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.orderCreationDateFiltrationControlPanel = new System.Windows.Forms.Panel();
			this.tbOrderCreationDate = new System.Windows.Forms.TextBox();
			this.orderDistrictFiltrationControlPanel = new System.Windows.Forms.Panel();
			this.tbOrderDistrict = new System.Windows.Forms.TextBox();
			this.cbReportDistrict = new System.Windows.Forms.ComboBox();
			this.btnCreateReport = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.cbReportTimeSeconds = new System.Windows.Forms.ComboBox();
			this.cbReportTimeMinutes = new System.Windows.Forms.ComboBox();
			this.cbReportTimeHours = new System.Windows.Forms.ComboBox();
			this.tbHoursInfo = new System.Windows.Forms.TextBox();
			this.tbMinutesInfo = new System.Windows.Forms.TextBox();
			this.tbSecondsInfo = new System.Windows.Forms.TextBox();
			this.timePickerFirstDeliveryDate = new System.Windows.Forms.DateTimePicker();
			this.orderCreationDateFiltrationControlPanel.SuspendLayout();
			this.orderDistrictFiltrationControlPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// orderCreationDateFiltrationControlPanel
			// 
			this.orderCreationDateFiltrationControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.timePickerFirstDeliveryDate);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.tbSecondsInfo);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.tbMinutesInfo);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.tbHoursInfo);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.cbReportTimeSeconds);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.cbReportTimeMinutes);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.cbReportTimeHours);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.tbOrderCreationDate);
			this.orderCreationDateFiltrationControlPanel.Location = new System.Drawing.Point(368, 12);
			this.orderCreationDateFiltrationControlPanel.Name = "orderCreationDateFiltrationControlPanel";
			this.orderCreationDateFiltrationControlPanel.Size = new System.Drawing.Size(508, 79);
			this.orderCreationDateFiltrationControlPanel.TabIndex = 5;
			// 
			// tbOrderCreationDate
			// 
			this.tbOrderCreationDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbOrderCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderCreationDate.Location = new System.Drawing.Point(3, 3);
			this.tbOrderCreationDate.Name = "tbOrderCreationDate";
			this.tbOrderCreationDate.ReadOnly = true;
			this.tbOrderCreationDate.Size = new System.Drawing.Size(344, 23);
			this.tbOrderCreationDate.TabIndex = 1;
			this.tbOrderCreationDate.Text = "ВРЕМЯ ПЕРВОЙ ДОСТАВКИ";
			this.tbOrderCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// orderDistrictFiltrationControlPanel
			// 
			this.orderDistrictFiltrationControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.orderDistrictFiltrationControlPanel.Controls.Add(this.tbOrderDistrict);
			this.orderDistrictFiltrationControlPanel.Controls.Add(this.cbReportDistrict);
			this.orderDistrictFiltrationControlPanel.Location = new System.Drawing.Point(12, 12);
			this.orderDistrictFiltrationControlPanel.Name = "orderDistrictFiltrationControlPanel";
			this.orderDistrictFiltrationControlPanel.Size = new System.Drawing.Size(350, 79);
			this.orderDistrictFiltrationControlPanel.TabIndex = 4;
			// 
			// tbOrderDistrict
			// 
			this.tbOrderDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbOrderDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderDistrict.Location = new System.Drawing.Point(3, 3);
			this.tbOrderDistrict.Name = "tbOrderDistrict";
			this.tbOrderDistrict.ReadOnly = true;
			this.tbOrderDistrict.Size = new System.Drawing.Size(344, 23);
			this.tbOrderDistrict.TabIndex = 1;
			this.tbOrderDistrict.Text = "РАЙОН ЗАКАЗА";
			this.tbOrderDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbReportDistrict
			// 
			this.cbReportDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbReportDistrict.FormattingEnabled = true;
			this.cbReportDistrict.Location = new System.Drawing.Point(3, 32);
			this.cbReportDistrict.Name = "cbReportDistrict";
			this.cbReportDistrict.Size = new System.Drawing.Size(344, 24);
			this.cbReportDistrict.TabIndex = 0;
			// 
			// btnCreateReport
			// 
			this.btnCreateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnCreateReport.Location = new System.Drawing.Point(882, 12);
			this.btnCreateReport.Name = "btnCreateReport";
			this.btnCreateReport.Size = new System.Drawing.Size(192, 37);
			this.btnCreateReport.TabIndex = 6;
			this.btnCreateReport.Text = "CREATE REPORT";
			this.btnCreateReport.UseVisualStyleBackColor = true;
			this.btnCreateReport.Click += new System.EventHandler(this.btnCreateReport_Click);
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnReset.Location = new System.Drawing.Point(882, 55);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(192, 36);
			this.btnReset.TabIndex = 7;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// cbReportTimeSeconds
			// 
			this.cbReportTimeSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbReportTimeSeconds.FormattingEnabled = true;
			this.cbReportTimeSeconds.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.cbReportTimeSeconds.Location = new System.Drawing.Point(454, 32);
			this.cbReportTimeSeconds.MaxLength = 2;
			this.cbReportTimeSeconds.Name = "cbReportTimeSeconds";
			this.cbReportTimeSeconds.Size = new System.Drawing.Size(40, 24);
			this.cbReportTimeSeconds.TabIndex = 12;
			// 
			// cbReportTimeMinutes
			// 
			this.cbReportTimeMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbReportTimeMinutes.FormattingEnabled = true;
			this.cbReportTimeMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
			this.cbReportTimeMinutes.Location = new System.Drawing.Point(408, 32);
			this.cbReportTimeMinutes.MaxLength = 2;
			this.cbReportTimeMinutes.Name = "cbReportTimeMinutes";
			this.cbReportTimeMinutes.Size = new System.Drawing.Size(40, 24);
			this.cbReportTimeMinutes.TabIndex = 11;
			// 
			// cbReportTimeHours
			// 
			this.cbReportTimeHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbReportTimeHours.FormattingEnabled = true;
			this.cbReportTimeHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
			this.cbReportTimeHours.Location = new System.Drawing.Point(362, 32);
			this.cbReportTimeHours.MaxLength = 2;
			this.cbReportTimeHours.Name = "cbReportTimeHours";
			this.cbReportTimeHours.Size = new System.Drawing.Size(40, 24);
			this.cbReportTimeHours.TabIndex = 10;
			// 
			// tbHoursInfo
			// 
			this.tbHoursInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbHoursInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbHoursInfo.Location = new System.Drawing.Point(362, 6);
			this.tbHoursInfo.Name = "tbHoursInfo";
			this.tbHoursInfo.ReadOnly = true;
			this.tbHoursInfo.Size = new System.Drawing.Size(40, 23);
			this.tbHoursInfo.TabIndex = 13;
			this.tbHoursInfo.Text = "ЧЧ";
			this.tbHoursInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbMinutesInfo
			// 
			this.tbMinutesInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbMinutesInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbMinutesInfo.Location = new System.Drawing.Point(408, 6);
			this.tbMinutesInfo.Name = "tbMinutesInfo";
			this.tbMinutesInfo.ReadOnly = true;
			this.tbMinutesInfo.Size = new System.Drawing.Size(40, 23);
			this.tbMinutesInfo.TabIndex = 14;
			this.tbMinutesInfo.Text = "ММ";
			this.tbMinutesInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// tbSecondsInfo
			// 
			this.tbSecondsInfo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbSecondsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbSecondsInfo.Location = new System.Drawing.Point(454, 6);
			this.tbSecondsInfo.Name = "tbSecondsInfo";
			this.tbSecondsInfo.ReadOnly = true;
			this.tbSecondsInfo.Size = new System.Drawing.Size(40, 23);
			this.tbSecondsInfo.TabIndex = 15;
			this.tbSecondsInfo.Text = "СС";
			this.tbSecondsInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// timePickerFirstDeliveryDate
			// 
			this.timePickerFirstDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timePickerFirstDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.timePickerFirstDeliveryDate.Location = new System.Drawing.Point(3, 33);
			this.timePickerFirstDeliveryDate.Name = "timePickerFirstDeliveryDate";
			this.timePickerFirstDeliveryDate.Size = new System.Drawing.Size(344, 23);
			this.timePickerFirstDeliveryDate.TabIndex = 16;
			// 
			// ReportCreation
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1086, 110);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.btnCreateReport);
			this.Controls.Add(this.orderCreationDateFiltrationControlPanel);
			this.Controls.Add(this.orderDistrictFiltrationControlPanel);
			this.Name = "ReportCreation";
			this.Text = "ReportCreation";
			this.orderCreationDateFiltrationControlPanel.ResumeLayout(false);
			this.orderCreationDateFiltrationControlPanel.PerformLayout();
			this.orderDistrictFiltrationControlPanel.ResumeLayout(false);
			this.orderDistrictFiltrationControlPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel orderCreationDateFiltrationControlPanel;
		private System.Windows.Forms.TextBox tbOrderCreationDate;
		private System.Windows.Forms.Panel orderDistrictFiltrationControlPanel;
		private System.Windows.Forms.TextBox tbOrderDistrict;
		private System.Windows.Forms.ComboBox cbReportDistrict;
		private System.Windows.Forms.Button btnCreateReport;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ComboBox cbReportTimeSeconds;
		private System.Windows.Forms.ComboBox cbReportTimeMinutes;
		private System.Windows.Forms.ComboBox cbReportTimeHours;
		private System.Windows.Forms.TextBox tbSecondsInfo;
		private System.Windows.Forms.TextBox tbMinutesInfo;
		private System.Windows.Forms.TextBox tbHoursInfo;
		private System.Windows.Forms.DateTimePicker timePickerFirstDeliveryDate;
	}
}