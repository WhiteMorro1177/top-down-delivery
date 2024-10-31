using DeliveryApp.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
	public partial class AddRecord : Form
	{
		private string _errorDescription = string.Empty;
		private Order _newOrder = null;
		internal Order NewOrder { get { return _newOrder; } }

		public AddRecord()
		{
			InitializeComponent();

			timePickerOrderCreationDate.MaxDate = DateTime.Today;
			timePickerOrderDeliveryDate.MaxDate = DateTime.Today;

			cbCreationDateHours.SelectedIndex = 0;
			cbCreationDateMinutes.SelectedIndex = 0;
			cbCreationDateSeconds.SelectedIndex = 0;

			cbDeliveryDateHours.SelectedIndex = 0;
			cbDeliveryDateMinutes.SelectedIndex = 0;
			cbDeliveryDateSeconds.SelectedIndex = 0;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			_newOrder = new Order();
			_errorDescription = string.Empty;
			tbErrors.Clear();

			cbCreationDateHours.ForeColor = Color.Black;
			cbCreationDateMinutes.ForeColor = Color.Black;
			cbCreationDateSeconds.ForeColor = Color.Black;

			cbDeliveryDateHours.ForeColor = Color.Black;
			cbDeliveryDateMinutes.ForeColor = Color.Black;
			cbDeliveryDateSeconds.ForeColor = Color.Black;

			timePickerOrderCreationDate.ForeColor = Color.Black;
			timePickerOrderDeliveryDate.ForeColor = Color.Black;

			tbOrderWeight.ForeColor = Color.Black;

			// check "Weight"
			double weight = 0;
			if (!double.TryParse(tbOrderWeight.Text.Replace(".", ","), out weight))
			{
				_errorDescription += "Некорректное значение веса";
				tbOrderWeight.ForeColor = Color.Red;
			}
			else _newOrder.Weight = weight;

			// check "District"
			string district = tbOrderDistrict.Text.Trim(' ');
			if (district == string.Empty)
			{
				_errorDescription += "\nНазвание района не может быть пустым";
			}
			else _newOrder.District = district;

			// check dates
			string rawCreationDate = $"{timePickerOrderCreationDate.Text} {cbCreationDateHours.SelectedItem}:{cbCreationDateMinutes.SelectedItem}:{cbCreationDateSeconds.SelectedItem}";
			string rawDeliveryDate = $"{timePickerOrderDeliveryDate.Text} {cbDeliveryDateHours.SelectedItem}:{cbDeliveryDateMinutes.SelectedItem}:{cbDeliveryDateSeconds.SelectedItem}";

			DateTime creationDate;
			if (!DateTime.TryParse(rawCreationDate, out creationDate))
			{
				_errorDescription += "\nНеверная дата создания заказа";

				cbCreationDateHours.ForeColor = Color.Red;
				cbCreationDateMinutes.ForeColor = Color.Red;
				cbCreationDateSeconds.ForeColor = Color.Red;

				tbErrors.Text = _errorDescription;
				return;
			}
			DateTime deliveryDate;
			if (!DateTime.TryParse(rawDeliveryDate, out deliveryDate))
			{
				_errorDescription += "\nНеверная дата создания заказа";

				cbDeliveryDateHours.ForeColor = Color.Red;
				cbDeliveryDateMinutes.ForeColor = Color.Red;
				cbDeliveryDateSeconds.ForeColor = Color.Red;

				tbErrors.Text = _errorDescription;
				return;
			}

			if (creationDate >= deliveryDate)
			{
				_errorDescription += "\nДата доставки не может быть боьше даты создания";

				cbCreationDateHours.ForeColor = Color.Red;
				cbCreationDateMinutes.ForeColor = Color.Red;
				cbCreationDateSeconds.ForeColor = Color.Red;

				cbDeliveryDateHours.ForeColor = Color.Red;
				cbDeliveryDateMinutes.ForeColor = Color.Red;
				cbDeliveryDateSeconds.ForeColor = Color.Red;

				timePickerOrderCreationDate.ForeColor = Color.Red;
				timePickerOrderDeliveryDate.ForeColor = Color.Red;
			}
			if (creationDate > DateTime.Now)
			{
				_errorDescription += "\nЗаказ не может быть создан из будущего)";
				cbCreationDateHours.ForeColor = Color.Red;
				cbCreationDateMinutes.ForeColor = Color.Red;
				cbCreationDateSeconds.ForeColor = Color.Red;
			} else _newOrder.CreationDate = creationDate;

			if (deliveryDate > DateTime.Now)
			{
				_errorDescription += "\nЗаказ не может быть доставлен в будущем)";
				cbDeliveryDateHours.ForeColor = Color.Red;
				cbDeliveryDateMinutes.ForeColor = Color.Red;
				cbDeliveryDateSeconds.ForeColor = Color.Red;
			} else _newOrder.DeliveryDate = deliveryDate;

			if (_errorDescription == string.Empty) this.Close();
			else tbErrors.Text = _errorDescription;
		}
	}
}
