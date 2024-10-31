using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeliveryApp.DTO
{
	internal class Order
	{
		public int Id { get; set; }					// Уникальный идентификатор заказа
		public double Weight { get; set; }			// Вес заказа
		public string District { get; set; }		// Район доставки
		public DateTime CreationDate { get; set; }	// Время создания заказа
		public DateTime DeliveryDate { get; set; }	// Время доставки заказа

		public Order() { }
		public Order(int id, double weight, string district, DateTime creationDate, DateTime deliveryDate)
		{
			Id = id;
			Weight = weight;
			District = district;
			CreationDate = creationDate;
			DeliveryDate = deliveryDate;
		}


		public override string ToString()
		{
			return $"Order ID: {Id}, Weight: {Weight}, District: {District}, Created: {CreationDate}, Delivery: {DeliveryDate}";
		}
	}
}
