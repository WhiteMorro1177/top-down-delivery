namespace DeliveryApp
{
	partial class AddRecord
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
			this.tbOrderWeight = new System.Windows.Forms.TextBox();
			this.labelOrderWeight = new System.Windows.Forms.Label();
			this.panelOrderWeight = new System.Windows.Forms.Panel();
			this.paneOrderDistrict = new System.Windows.Forms.Panel();
			this.labelOrderDistrict = new System.Windows.Forms.Label();
			this.tbOrderDistrict = new System.Windows.Forms.TextBox();
			this.panelOrderCreationDate = new System.Windows.Forms.Panel();
			this.cbCreationDateSeconds = new System.Windows.Forms.ComboBox();
			this.cbCreationDateMinutes = new System.Windows.Forms.ComboBox();
			this.cbCreationDateHours = new System.Windows.Forms.ComboBox();
			this.timePickerOrderCreationDate = new System.Windows.Forms.DateTimePicker();
			this.labelOrderCreationDate = new System.Windows.Forms.Label();
			this.panelOrderDeliveryDate = new System.Windows.Forms.Panel();
			this.timePickerOrderDeliveryDate = new System.Windows.Forms.DateTimePicker();
			this.labelOrderDeliveryDate = new System.Windows.Forms.Label();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.panelErrors = new System.Windows.Forms.Panel();
			this.tbErrors = new System.Windows.Forms.TextBox();
			this.cbDeliveryDateSeconds = new System.Windows.Forms.ComboBox();
			this.cbDeliveryDateMinutes = new System.Windows.Forms.ComboBox();
			this.cbDeliveryDateHours = new System.Windows.Forms.ComboBox();
			this.panelOrderWeight.SuspendLayout();
			this.paneOrderDistrict.SuspendLayout();
			this.panelOrderCreationDate.SuspendLayout();
			this.panelOrderDeliveryDate.SuspendLayout();
			this.panelErrors.SuspendLayout();
			this.SuspendLayout();
			// 
			// tbOrderWeight
			// 
			this.tbOrderWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderWeight.Location = new System.Drawing.Point(6, 20);
			this.tbOrderWeight.Name = "tbOrderWeight";
			this.tbOrderWeight.Size = new System.Drawing.Size(356, 23);
			this.tbOrderWeight.TabIndex = 0;
			// 
			// labelOrderWeight
			// 
			this.labelOrderWeight.AutoSize = true;
			this.labelOrderWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrderWeight.Location = new System.Drawing.Point(3, 0);
			this.labelOrderWeight.Name = "labelOrderWeight";
			this.labelOrderWeight.Size = new System.Drawing.Size(52, 17);
			this.labelOrderWeight.TabIndex = 1;
			this.labelOrderWeight.Text = "Weight";
			// 
			// panelOrderWeight
			// 
			this.panelOrderWeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelOrderWeight.Controls.Add(this.labelOrderWeight);
			this.panelOrderWeight.Controls.Add(this.tbOrderWeight);
			this.panelOrderWeight.Location = new System.Drawing.Point(12, 12);
			this.panelOrderWeight.Name = "panelOrderWeight";
			this.panelOrderWeight.Size = new System.Drawing.Size(365, 58);
			this.panelOrderWeight.TabIndex = 2;
			// 
			// paneOrderDistrict
			// 
			this.paneOrderDistrict.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.paneOrderDistrict.Controls.Add(this.labelOrderDistrict);
			this.paneOrderDistrict.Controls.Add(this.tbOrderDistrict);
			this.paneOrderDistrict.Location = new System.Drawing.Point(12, 76);
			this.paneOrderDistrict.Name = "paneOrderDistrict";
			this.paneOrderDistrict.Size = new System.Drawing.Size(365, 58);
			this.paneOrderDistrict.TabIndex = 3;
			// 
			// labelOrderDistrict
			// 
			this.labelOrderDistrict.AutoSize = true;
			this.labelOrderDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrderDistrict.Location = new System.Drawing.Point(3, 0);
			this.labelOrderDistrict.Name = "labelOrderDistrict";
			this.labelOrderDistrict.Size = new System.Drawing.Size(51, 17);
			this.labelOrderDistrict.TabIndex = 1;
			this.labelOrderDistrict.Text = "District";
			// 
			// tbOrderDistrict
			// 
			this.tbOrderDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderDistrict.Location = new System.Drawing.Point(6, 20);
			this.tbOrderDistrict.Name = "tbOrderDistrict";
			this.tbOrderDistrict.Size = new System.Drawing.Size(356, 23);
			this.tbOrderDistrict.TabIndex = 0;
			// 
			// panelOrderCreationDate
			// 
			this.panelOrderCreationDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelOrderCreationDate.Controls.Add(this.cbCreationDateSeconds);
			this.panelOrderCreationDate.Controls.Add(this.cbCreationDateMinutes);
			this.panelOrderCreationDate.Controls.Add(this.cbCreationDateHours);
			this.panelOrderCreationDate.Controls.Add(this.timePickerOrderCreationDate);
			this.panelOrderCreationDate.Controls.Add(this.labelOrderCreationDate);
			this.panelOrderCreationDate.Location = new System.Drawing.Point(12, 140);
			this.panelOrderCreationDate.Name = "panelOrderCreationDate";
			this.panelOrderCreationDate.Size = new System.Drawing.Size(365, 58);
			this.panelOrderCreationDate.TabIndex = 4;
			// 
			// cbCreationDateSeconds
			// 
			this.cbCreationDateSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbCreationDateSeconds.FormattingEnabled = true;
			this.cbCreationDateSeconds.Items.AddRange(new object[] {
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
			this.cbCreationDateSeconds.Location = new System.Drawing.Point(309, 20);
			this.cbCreationDateSeconds.MaxLength = 2;
			this.cbCreationDateSeconds.Name = "cbCreationDateSeconds";
			this.cbCreationDateSeconds.Size = new System.Drawing.Size(40, 24);
			this.cbCreationDateSeconds.TabIndex = 9;
			// 
			// cbCreationDateMinutes
			// 
			this.cbCreationDateMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbCreationDateMinutes.FormattingEnabled = true;
			this.cbCreationDateMinutes.Items.AddRange(new object[] {
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
			this.cbCreationDateMinutes.Location = new System.Drawing.Point(263, 20);
			this.cbCreationDateMinutes.MaxLength = 2;
			this.cbCreationDateMinutes.Name = "cbCreationDateMinutes";
			this.cbCreationDateMinutes.Size = new System.Drawing.Size(40, 24);
			this.cbCreationDateMinutes.TabIndex = 8;
			// 
			// cbCreationDateHours
			// 
			this.cbCreationDateHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbCreationDateHours.FormattingEnabled = true;
			this.cbCreationDateHours.Items.AddRange(new object[] {
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
			this.cbCreationDateHours.Location = new System.Drawing.Point(217, 20);
			this.cbCreationDateHours.MaxLength = 2;
			this.cbCreationDateHours.Name = "cbCreationDateHours";
			this.cbCreationDateHours.Size = new System.Drawing.Size(40, 24);
			this.cbCreationDateHours.TabIndex = 7;
			// 
			// timePickerOrderCreationDate
			// 
			this.timePickerOrderCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timePickerOrderCreationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.timePickerOrderCreationDate.Location = new System.Drawing.Point(6, 20);
			this.timePickerOrderCreationDate.MaxDate = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
			this.timePickerOrderCreationDate.Name = "timePickerOrderCreationDate";
			this.timePickerOrderCreationDate.Size = new System.Drawing.Size(181, 23);
			this.timePickerOrderCreationDate.TabIndex = 6;
			this.timePickerOrderCreationDate.Value = new System.DateTime(2024, 10, 31, 0, 0, 0, 0);
			// 
			// labelOrderCreationDate
			// 
			this.labelOrderCreationDate.AutoSize = true;
			this.labelOrderCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrderCreationDate.Location = new System.Drawing.Point(3, 0);
			this.labelOrderCreationDate.Name = "labelOrderCreationDate";
			this.labelOrderCreationDate.Size = new System.Drawing.Size(95, 17);
			this.labelOrderCreationDate.TabIndex = 1;
			this.labelOrderCreationDate.Text = "Creation Date";
			// 
			// panelOrderDeliveryDate
			// 
			this.panelOrderDeliveryDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelOrderDeliveryDate.Controls.Add(this.cbDeliveryDateSeconds);
			this.panelOrderDeliveryDate.Controls.Add(this.timePickerOrderDeliveryDate);
			this.panelOrderDeliveryDate.Controls.Add(this.cbDeliveryDateMinutes);
			this.panelOrderDeliveryDate.Controls.Add(this.cbDeliveryDateHours);
			this.panelOrderDeliveryDate.Controls.Add(this.labelOrderDeliveryDate);
			this.panelOrderDeliveryDate.Location = new System.Drawing.Point(12, 204);
			this.panelOrderDeliveryDate.Name = "panelOrderDeliveryDate";
			this.panelOrderDeliveryDate.Size = new System.Drawing.Size(365, 58);
			this.panelOrderDeliveryDate.TabIndex = 3;
			// 
			// timePickerOrderDeliveryDate
			// 
			this.timePickerOrderDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.timePickerOrderDeliveryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.timePickerOrderDeliveryDate.Location = new System.Drawing.Point(6, 20);
			this.timePickerOrderDeliveryDate.Name = "timePickerOrderDeliveryDate";
			this.timePickerOrderDeliveryDate.Size = new System.Drawing.Size(181, 23);
			this.timePickerOrderDeliveryDate.TabIndex = 7;
			// 
			// labelOrderDeliveryDate
			// 
			this.labelOrderDeliveryDate.AutoSize = true;
			this.labelOrderDeliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelOrderDeliveryDate.Location = new System.Drawing.Point(3, 0);
			this.labelOrderDeliveryDate.Name = "labelOrderDeliveryDate";
			this.labelOrderDeliveryDate.Size = new System.Drawing.Size(93, 17);
			this.labelOrderDeliveryDate.TabIndex = 1;
			this.labelOrderDeliveryDate.Text = "Delivery Date";
			// 
			// buttonAdd
			// 
			this.buttonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAdd.Location = new System.Drawing.Point(12, 344);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(365, 50);
			this.buttonAdd.TabIndex = 5;
			this.buttonAdd.Text = "ADD RECORD";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// panelErrors
			// 
			this.panelErrors.Controls.Add(this.tbErrors);
			this.panelErrors.Location = new System.Drawing.Point(12, 268);
			this.panelErrors.Name = "panelErrors";
			this.panelErrors.Size = new System.Drawing.Size(365, 70);
			this.panelErrors.TabIndex = 6;
			// 
			// tbErrors
			// 
			this.tbErrors.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbErrors.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbErrors.Location = new System.Drawing.Point(0, 0);
			this.tbErrors.Multiline = true;
			this.tbErrors.Name = "tbErrors";
			this.tbErrors.ReadOnly = true;
			this.tbErrors.Size = new System.Drawing.Size(365, 67);
			this.tbErrors.TabIndex = 0;
			// 
			// cbDeliveryDateSeconds
			// 
			this.cbDeliveryDateSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbDeliveryDateSeconds.FormattingEnabled = true;
			this.cbDeliveryDateSeconds.Items.AddRange(new object[] {
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
			this.cbDeliveryDateSeconds.Location = new System.Drawing.Point(309, 19);
			this.cbDeliveryDateSeconds.MaxLength = 2;
			this.cbDeliveryDateSeconds.Name = "cbDeliveryDateSeconds";
			this.cbDeliveryDateSeconds.Size = new System.Drawing.Size(40, 24);
			this.cbDeliveryDateSeconds.TabIndex = 12;
			// 
			// cbDeliveryDateMinutes
			// 
			this.cbDeliveryDateMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbDeliveryDateMinutes.FormattingEnabled = true;
			this.cbDeliveryDateMinutes.Items.AddRange(new object[] {
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
			this.cbDeliveryDateMinutes.Location = new System.Drawing.Point(263, 19);
			this.cbDeliveryDateMinutes.MaxLength = 2;
			this.cbDeliveryDateMinutes.Name = "cbDeliveryDateMinutes";
			this.cbDeliveryDateMinutes.Size = new System.Drawing.Size(40, 24);
			this.cbDeliveryDateMinutes.TabIndex = 11;
			// 
			// cbDeliveryDateHours
			// 
			this.cbDeliveryDateHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbDeliveryDateHours.FormattingEnabled = true;
			this.cbDeliveryDateHours.Items.AddRange(new object[] {
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
			this.cbDeliveryDateHours.Location = new System.Drawing.Point(217, 19);
			this.cbDeliveryDateHours.MaxLength = 2;
			this.cbDeliveryDateHours.Name = "cbDeliveryDateHours";
			this.cbDeliveryDateHours.Size = new System.Drawing.Size(40, 24);
			this.cbDeliveryDateHours.TabIndex = 10;
			// 
			// AddRecord
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 406);
			this.Controls.Add(this.panelErrors);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.panelOrderDeliveryDate);
			this.Controls.Add(this.panelOrderCreationDate);
			this.Controls.Add(this.paneOrderDistrict);
			this.Controls.Add(this.panelOrderWeight);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "AddRecord";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AddRecord";
			this.panelOrderWeight.ResumeLayout(false);
			this.panelOrderWeight.PerformLayout();
			this.paneOrderDistrict.ResumeLayout(false);
			this.paneOrderDistrict.PerformLayout();
			this.panelOrderCreationDate.ResumeLayout(false);
			this.panelOrderCreationDate.PerformLayout();
			this.panelOrderDeliveryDate.ResumeLayout(false);
			this.panelOrderDeliveryDate.PerformLayout();
			this.panelErrors.ResumeLayout(false);
			this.panelErrors.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TextBox tbOrderWeight;
		private System.Windows.Forms.Label labelOrderWeight;
		private System.Windows.Forms.Panel panelOrderWeight;
		private System.Windows.Forms.Panel paneOrderDistrict;
		private System.Windows.Forms.Label labelOrderDistrict;
		private System.Windows.Forms.TextBox tbOrderDistrict;
		private System.Windows.Forms.Panel panelOrderCreationDate;
		private System.Windows.Forms.Label labelOrderCreationDate;
		private System.Windows.Forms.Panel panelOrderDeliveryDate;
		private System.Windows.Forms.Label labelOrderDeliveryDate;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.DateTimePicker timePickerOrderCreationDate;
		private System.Windows.Forms.DateTimePicker timePickerOrderDeliveryDate;
		private System.Windows.Forms.Panel panelErrors;
		private System.Windows.Forms.TextBox tbErrors;
		private System.Windows.Forms.ComboBox cbCreationDateSeconds;
		private System.Windows.Forms.ComboBox cbCreationDateMinutes;
		private System.Windows.Forms.ComboBox cbCreationDateHours;
		private System.Windows.Forms.ComboBox cbDeliveryDateSeconds;
		private System.Windows.Forms.ComboBox cbDeliveryDateMinutes;
		private System.Windows.Forms.ComboBox cbDeliveryDateHours;
	}
}