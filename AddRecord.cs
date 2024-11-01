using DeliveryApp.DTO;
using DeliveryApp.helper;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DeliveryApp
{
	public partial class AddRecord : Form
	{
		private Logger logger;

		private string _errorDescription = string.Empty;
		private Order _newOrder = null;
		internal Order NewOrder { get { return _newOrder; } }

		public AddRecord()
		{
			logger = Logger.GetLogger;

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
			double weight;
			if (!double.TryParse(tbOrderWeight.Text.Replace(".", ","), out weight))
			{
				_errorDescription += "Некорректное значение веса";
				tbOrderWeight.ForeColor = Color.Red;
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect weight");
			}
			else _newOrder.Weight = weight;

			// check "District"
			string district = tbOrderDistrict.Text.Trim(' ');
			if (district == string.Empty)
			{
				_errorDescription += "\nНазвание района не может быть пустым";
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect district - Cannot be empty");
			}
			else _newOrder.District = district;

			// check dates
			string rawCreationTime = $"{cbCreationDateHours.SelectedItem}:{cbCreationDateMinutes.SelectedItem}:{cbCreationDateSeconds.SelectedItem}";
			string rawDeliveryTime = $"{cbDeliveryDateHours.SelectedItem}:{cbDeliveryDateMinutes.SelectedItem}:{cbDeliveryDateSeconds.SelectedItem}";

			string rawCreationDate = string.Join("-", timePickerOrderCreationDate.Text.Split('.').Reverse());
			string rawDeliveryDate = string.Join("-", timePickerOrderDeliveryDate.Text.Split('.').Reverse());

			string rawCreationDateTime = DateTimeFormatter.FormatToStringLong(DateTimeFormatter.FormatToDateTime(rawCreationDate, rawCreationTime));
			string rawDeliveryDateTime = DateTimeFormatter.FormatToStringLong(DateTimeFormatter.FormatToDateTime(rawDeliveryDate, rawDeliveryTime));

			DateTime creationDate;
			if (!DateTime.TryParse(rawCreationDateTime, out creationDate))
			{
				_errorDescription += "\nНеверная дата создания заказа";

				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect creation date - Unexpected token");

				cbCreationDateHours.ForeColor = Color.Red;
				cbCreationDateMinutes.ForeColor = Color.Red;
				cbCreationDateSeconds.ForeColor = Color.Red;

				tbErrors.Text = _errorDescription;
				return;
			}
			DateTime deliveryDate;
			if (!DateTime.TryParse(rawDeliveryDateTime, out deliveryDate))
			{
				_errorDescription += "\nНеверная дата создания заказа";
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect delivery date - Unexpected token");


				cbDeliveryDateHours.ForeColor = Color.Red;
				cbDeliveryDateMinutes.ForeColor = Color.Red;
				cbDeliveryDateSeconds.ForeColor = Color.Red;

				tbErrors.Text = _errorDescription;
				return;
			}

			Debug.WriteLine(creationDate);
			Debug.WriteLine(deliveryDate);


			if (creationDate >= deliveryDate)
			{
				_errorDescription += "\nДата создания не может быть позже даты доставки";
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect date - create after delivery");


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
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect creation date - Grater than DateTime.Now");

				cbCreationDateHours.ForeColor = Color.Red;
				cbCreationDateMinutes.ForeColor = Color.Red;
				cbCreationDateSeconds.ForeColor = Color.Red;
			}
			else _newOrder.CreationDate = creationDate;

			if (deliveryDate > DateTime.Now)
			{
				_errorDescription += "\nЗаказ не может быть доставлен в будущем)";
				logger.Log(Logger.LogLevel.WARNING, GetType().FullName, "Incorrect delivery date - Grater than DateTime.Now");

				cbDeliveryDateHours.ForeColor = Color.Red;
				cbDeliveryDateMinutes.ForeColor = Color.Red;
				cbDeliveryDateSeconds.ForeColor = Color.Red;
			}
			else _newOrder.DeliveryDate = deliveryDate;

			if (_errorDescription == string.Empty) this.Close();
			else 
			{
				tbErrors.Text = _errorDescription;
				_newOrder = null;
			}
		}
	}
}
