using System.Collections.Generic;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using DeliveryApp.DTO;
using Newtonsoft.Json;
using System;
using System.Linq;

namespace DeliveryApp
{
	public partial class MainForm : Form
	{
		// private readonly MongoClient _client = new MongoClient("mongodb://10.241.167.184:27017");

		private static List<Order> lvDeliveryDataCache = null;
		private Config config;
		private Logger logger;

		public MainForm()
		{
			// parse config
			config = Config.GetConfig; // TODO(Create "Options" and oportunity to rewrite config)
			logger = Logger.GetLogger;

			// try to load backup from previous session
			// if not -> load test "init" data
			string backupFilePath = config.BackupDirectory + "backup.json";
			List<Order> orders = new List<Order>();
			if (File.Exists(backupFilePath))
			{
				string rawBackupData = File.ReadAllText(backupFilePath);
				orders = JsonConvert.DeserializeObject<List<Order>>(rawBackupData);
			}
			else
			{
				// get data from init_json
				string rawInitData = File.ReadAllText(config.DataDirectory + "init_data.json");
				orders = JsonConvert.DeserializeObject<List<Order>>(rawInitData);
			}

			InitializeComponent();

			// write all data to app
			FillDeliveryData(orders);
			FillFilterOptions(orders);
		}

		private void FillFilterOptions(List<Order> orders)
		{
			List<string> districts = new List<string>();
			List<string> dates = new List<string>();
			orders.ForEach(order =>
			{
				if (!districts.Contains(order.District)) districts.Add(order.District);

				string tmpShprtDate = order.CreationDate.ToShortDateString();
				if (!dates.Contains(tmpShprtDate)) dates.Add(tmpShprtDate);
			});

			cbOrderDistrict.Items.AddRange(districts.ToArray());
			cbOrderCreationDate.Items.AddRange(dates.ToArray());
		}

		private void FillDeliveryData(List<Order> orders)
		{
			if (orders.Count == 0) return;

			orders.ForEach(order =>
			{
				// create order record
				ListViewItem orderRecord = new ListViewItem(order.Id.ToString());
				orderRecord.SubItems.Add(order.Weight.ToString());
				orderRecord.SubItems.Add(order.District);
				orderRecord.SubItems.Add(order.CreationDate.ToString());
				orderRecord.SubItems.Add(order.DeliveryDate.ToString());

				// add record to list veiw
				lvDeliveryData.Items.Add(orderRecord);
			});
		}

		private void RefillDeliveryData(List<Order> orders)
		{
			lvDeliveryData.Items.Clear();
			FillDeliveryData(orders);
		}

		private List<Order> GetCurrentDeliveryData()
		{
			List<Order> orders = new List<Order>();

			foreach (ListViewItem lvItem in lvDeliveryData.Items)
			{
				Order order = new Order();
				order.Id = int.Parse(lvItem.Text);
				order.Weight = double.Parse(lvItem.SubItems[1].Text);
				order.District = lvItem.SubItems[2].Text;
				order.CreationDate = DateTime.Parse(lvItem.SubItems[3].Text);
				order.DeliveryDate = DateTime.Parse(lvItem.SubItems[4].Text);

				orders.Add(order);
			}

			return orders;
		}

		private void btnFilter_Click(object sender, EventArgs e)
		{
			bool hasError = false;
			// save full list of orders
			if (lvDeliveryDataCache == null) { lvDeliveryDataCache = GetCurrentDeliveryData(); }

			// update ListVeiw using filters
			string districtFilter = cbOrderDistrict.Text;
			string dateFilter = cbOrderCreationDate.Text;

			if (districtFilter == "" && dateFilter == "") return;

			if (!lvDeliveryDataCache.Select(order => order.District).Contains(districtFilter))
			{
				cbOrderDistrict.Text = null;
				hasError = true;
			}
			if (!lvDeliveryDataCache.Select(order => order.CreationDate.ToShortDateString()).Contains(dateFilter))
			{
				cbOrderCreationDate.Text = null;
				hasError = true;
			}

			if (hasError) return;

			List<Order> orders = lvDeliveryDataCache.Where(
				order =>
				{
					if (districtFilter == "") return true;
					return order.District == districtFilter;
				}).Where(order =>
				{
					if (dateFilter == "") return true;
					return order.CreationDate.ToShortDateString() == dateFilter;
				}).ToList();

			RefillDeliveryData(orders);
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			// erase Combo Boxes values
			cbOrderDistrict.SelectedItem = null;
			cbOrderCreationDate.SelectedItem = null;
			// reset ListVeiw
			if (lvDeliveryDataCache != null)
			{
				RefillDeliveryData(lvDeliveryDataCache);
			}
		}

		private void addRecordToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AddRecord addNewRecordForm = new AddRecord();

			addNewRecordForm.ShowDialog();

			Order orderToAdd = addNewRecordForm.NewOrder;

			if (orderToAdd != null)
			{
				// generate ID for new order
				List<int> ids = new List<int>();

				if (lvDeliveryDataCache == null) ids = GetCurrentDeliveryData().Select(order => order.Id).ToList();
				else ids = lvDeliveryDataCache.Select(order => order.Id).ToList();

				ids.Sort();
				orderToAdd.Id = ids.Last() + 1;

				// write new order to list veiw
				FillDeliveryData(new List<Order> { orderToAdd });
			}
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			List<Order> ordersBackup = new List<Order>();
			if (lvDeliveryDataCache == null) ordersBackup = GetCurrentDeliveryData();
			else ordersBackup = lvDeliveryDataCache;

			string jsonOrders = JsonConvert.SerializeObject(ordersBackup);

			File.WriteAllText(config.BackupDirectory + "backup.json", jsonOrders);
		}

		private void createReportToolStripMenuItem_Click(object sender, EventArgs e)
		{
			List<string> districts = new List<string>();
			foreach (var district in cbOrderDistrict.Items) districts.Add(district.ToString());
			
			ReportCreation reportCreationForm = new ReportCreation(districts);
			reportCreationForm.ShowDialog();

			DateTime startReportDate = reportCreationForm.StartReportDate;
			DateTime endReportDate = reportCreationForm.EndReportDate;
			string reportDistrict = reportCreationForm.ReportDistrict;

			if (startReportDate == null) return;
			if (endReportDate == null) return;
			if (reportDistrict == null) return;

			List<Order> orders = new List<Order>();
			if (lvDeliveryDataCache == null) orders = GetCurrentDeliveryData();
			else orders = lvDeliveryDataCache;

			List<Order> ordersForReport = orders.Where(order =>
			{
				if (order.District == reportDistrict)
				{
					if (order.DeliveryDate > startReportDate)
					{
						if (order.DeliveryDate < endReportDate) return true;
					}
				}
				return false;
			}).ToList();


			string jsonReport = JsonConvert.SerializeObject(ordersForReport);
			string reportDate = DateTime.Now.ToString();
			File.WriteAllText(config.ReportsDirectory + $"report_{reportDate}", jsonReport);
		}
	}
}
