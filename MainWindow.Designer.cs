namespace DeliveryApp
{
	partial class MainForm
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.scMain = new System.Windows.Forms.SplitContainer();
			this.btnReset = new System.Windows.Forms.Button();
			this.btnFilter = new System.Windows.Forms.Button();
			this.orderCreationDateFiltrationControlPanel = new System.Windows.Forms.Panel();
			this.tbOrderCreationDate = new System.Windows.Forms.TextBox();
			this.cbOrderCreationDate = new System.Windows.Forms.ComboBox();
			this.orderDistrictFiltrationControlPanel = new System.Windows.Forms.Panel();
			this.tbOrderDistrict = new System.Windows.Forms.TextBox();
			this.cbOrderDistrict = new System.Windows.Forms.ComboBox();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.addRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportCreationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.lvDeliveryData = new System.Windows.Forms.ListView();
			this.columnHeaderNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderWeight = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDistrict = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderCreationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeaderDeliveryDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
			this.scMain.Panel1.SuspendLayout();
			this.scMain.Panel2.SuspendLayout();
			this.scMain.SuspendLayout();
			this.orderCreationDateFiltrationControlPanel.SuspendLayout();
			this.orderDistrictFiltrationControlPanel.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// scMain
			// 
			this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.scMain.Location = new System.Drawing.Point(0, 0);
			this.scMain.Name = "scMain";
			this.scMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// scMain.Panel1
			// 
			this.scMain.Panel1.Controls.Add(this.btnReset);
			this.scMain.Panel1.Controls.Add(this.btnFilter);
			this.scMain.Panel1.Controls.Add(this.orderCreationDateFiltrationControlPanel);
			this.scMain.Panel1.Controls.Add(this.orderDistrictFiltrationControlPanel);
			this.scMain.Panel1.Controls.Add(this.menuStrip1);
			// 
			// scMain.Panel2
			// 
			this.scMain.Panel2.Controls.Add(this.lvDeliveryData);
			this.scMain.Size = new System.Drawing.Size(951, 681);
			this.scMain.SplitterDistance = 109;
			this.scMain.TabIndex = 2;
			// 
			// btnReset
			// 
			this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnReset.Location = new System.Drawing.Point(724, 69);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(215, 37);
			this.btnReset.TabIndex = 5;
			this.btnReset.Text = "RESET";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
			// 
			// btnFilter
			// 
			this.btnFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnFilter.Location = new System.Drawing.Point(724, 26);
			this.btnFilter.Name = "btnFilter";
			this.btnFilter.Size = new System.Drawing.Size(215, 37);
			this.btnFilter.TabIndex = 4;
			this.btnFilter.Text = "FILTER";
			this.btnFilter.UseVisualStyleBackColor = true;
			this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
			// 
			// orderCreationDateFiltrationControlPanel
			// 
			this.orderCreationDateFiltrationControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.tbOrderCreationDate);
			this.orderCreationDateFiltrationControlPanel.Controls.Add(this.cbOrderCreationDate);
			this.orderCreationDateFiltrationControlPanel.Location = new System.Drawing.Point(368, 27);
			this.orderCreationDateFiltrationControlPanel.Name = "orderCreationDateFiltrationControlPanel";
			this.orderCreationDateFiltrationControlPanel.Size = new System.Drawing.Size(350, 79);
			this.orderCreationDateFiltrationControlPanel.TabIndex = 3;
			// 
			// tbOrderCreationDate
			// 
			this.tbOrderCreationDate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbOrderCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderCreationDate.Location = new System.Drawing.Point(3, 3);
			this.tbOrderCreationDate.Name = "tbOrderCreationDate";
			this.tbOrderCreationDate.ReadOnly = true;
			this.tbOrderCreationDate.Size = new System.Drawing.Size(291, 23);
			this.tbOrderCreationDate.TabIndex = 1;
			this.tbOrderCreationDate.Text = "ВРЕМЯ СОЗДАНИЯ ЗАКАЗА";
			this.tbOrderCreationDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbOrderCreationDate
			// 
			this.cbOrderCreationDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbOrderCreationDate.FormattingEnabled = true;
			this.cbOrderCreationDate.Location = new System.Drawing.Point(3, 32);
			this.cbOrderCreationDate.Name = "cbOrderCreationDate";
			this.cbOrderCreationDate.Size = new System.Drawing.Size(291, 24);
			this.cbOrderCreationDate.TabIndex = 0;
			// 
			// orderDistrictFiltrationControlPanel
			// 
			this.orderDistrictFiltrationControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.orderDistrictFiltrationControlPanel.Controls.Add(this.tbOrderDistrict);
			this.orderDistrictFiltrationControlPanel.Controls.Add(this.cbOrderDistrict);
			this.orderDistrictFiltrationControlPanel.Location = new System.Drawing.Point(12, 27);
			this.orderDistrictFiltrationControlPanel.Name = "orderDistrictFiltrationControlPanel";
			this.orderDistrictFiltrationControlPanel.Size = new System.Drawing.Size(350, 79);
			this.orderDistrictFiltrationControlPanel.TabIndex = 2;
			// 
			// tbOrderDistrict
			// 
			this.tbOrderDistrict.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.tbOrderDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbOrderDistrict.Location = new System.Drawing.Point(3, 3);
			this.tbOrderDistrict.Name = "tbOrderDistrict";
			this.tbOrderDistrict.ReadOnly = true;
			this.tbOrderDistrict.Size = new System.Drawing.Size(291, 23);
			this.tbOrderDistrict.TabIndex = 1;
			this.tbOrderDistrict.Text = "РАЙОН ЗАКАЗА";
			this.tbOrderDistrict.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// cbOrderDistrict
			// 
			this.cbOrderDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.cbOrderDistrict.FormattingEnabled = true;
			this.cbOrderDistrict.Location = new System.Drawing.Point(3, 32);
			this.cbOrderDistrict.Name = "cbOrderDistrict";
			this.cbOrderDistrict.Size = new System.Drawing.Size(291, 24);
			this.cbOrderDistrict.TabIndex = 0;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportCreationToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(951, 24);
			this.menuStrip1.TabIndex = 3;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRecordToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
			this.fileToolStripMenuItem.Text = "Файл";
			// 
			// addRecordToolStripMenuItem
			// 
			this.addRecordToolStripMenuItem.Name = "addRecordToolStripMenuItem";
			this.addRecordToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
			this.addRecordToolStripMenuItem.Text = "Добавить запись";
			this.addRecordToolStripMenuItem.Click += new System.EventHandler(this.addRecordToolStripMenuItem_Click);
			// 
			// reportCreationToolStripMenuItem
			// 
			this.reportCreationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem});
			this.reportCreationToolStripMenuItem.Name = "reportCreationToolStripMenuItem";
			this.reportCreationToolStripMenuItem.Size = new System.Drawing.Size(143, 20);
			this.reportCreationToolStripMenuItem.Text = "Формирование отчёта";
			// 
			// createReportToolStripMenuItem
			// 
			this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
			this.createReportToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.createReportToolStripMenuItem.Text = "Сформировать";
			this.createReportToolStripMenuItem.Click += new System.EventHandler(this.createReportToolStripMenuItem_Click);
			// 
			// lvDeliveryData
			// 
			this.lvDeliveryData.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNumber,
            this.columnHeaderWeight,
            this.columnHeaderDistrict,
            this.columnHeaderCreationDate,
            this.columnHeaderDeliveryDate});
			this.lvDeliveryData.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lvDeliveryData.GridLines = true;
			this.lvDeliveryData.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
			this.lvDeliveryData.HideSelection = false;
			this.lvDeliveryData.LabelWrap = false;
			this.lvDeliveryData.Location = new System.Drawing.Point(0, 0);
			this.lvDeliveryData.Name = "lvDeliveryData";
			this.lvDeliveryData.Size = new System.Drawing.Size(951, 568);
			this.lvDeliveryData.TabIndex = 0;
			this.lvDeliveryData.UseCompatibleStateImageBehavior = false;
			this.lvDeliveryData.View = System.Windows.Forms.View.Details;
			// 
			// columnHeaderNumber
			// 
			this.columnHeaderNumber.Text = "Number";
			this.columnHeaderNumber.Width = 113;
			// 
			// columnHeaderWeight
			// 
			this.columnHeaderWeight.Text = "Weight";
			this.columnHeaderWeight.Width = 107;
			// 
			// columnHeaderDistrict
			// 
			this.columnHeaderDistrict.Text = "District";
			this.columnHeaderDistrict.Width = 143;
			// 
			// columnHeaderCreationDate
			// 
			this.columnHeaderCreationDate.Text = "CreationDate";
			this.columnHeaderCreationDate.Width = 232;
			// 
			// columnHeaderDeliveryDate
			// 
			this.columnHeaderDeliveryDate.Text = "DeliveryDate";
			this.columnHeaderDeliveryDate.Width = 220;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(951, 681);
			this.Controls.Add(this.scMain);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TopDownDelivery";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
			this.scMain.Panel1.ResumeLayout(false);
			this.scMain.Panel1.PerformLayout();
			this.scMain.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
			this.scMain.ResumeLayout(false);
			this.orderCreationDateFiltrationControlPanel.ResumeLayout(false);
			this.orderCreationDateFiltrationControlPanel.PerformLayout();
			this.orderDistrictFiltrationControlPanel.ResumeLayout(false);
			this.orderDistrictFiltrationControlPanel.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.SplitContainer scMain;
		private System.Windows.Forms.TextBox tbOrderDistrict;
		private System.Windows.Forms.ComboBox cbOrderDistrict;
		private System.Windows.Forms.Panel orderDistrictFiltrationControlPanel;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel orderCreationDateFiltrationControlPanel;
		private System.Windows.Forms.TextBox tbOrderCreationDate;
		private System.Windows.Forms.ComboBox cbOrderCreationDate;
		private System.Windows.Forms.ToolStripMenuItem reportCreationToolStripMenuItem;
		private System.Windows.Forms.ListView lvDeliveryData;
		private System.Windows.Forms.ColumnHeader columnHeaderNumber;
		private System.Windows.Forms.ColumnHeader columnHeaderWeight;
		private System.Windows.Forms.ColumnHeader columnHeaderDistrict;
		private System.Windows.Forms.ColumnHeader columnHeaderCreationDate;
		private System.Windows.Forms.ColumnHeader columnHeaderDeliveryDate;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem addRecordToolStripMenuItem;
		private System.Windows.Forms.Button btnFilter;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
	}
}

