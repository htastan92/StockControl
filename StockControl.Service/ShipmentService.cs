using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class ShipmentService : IShipmentService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Shipment> shipmentRepository;
		public ShipmentService(IUnitOfWork unitOfWork,IRepository<Shipment> shipmentRepository)
		{
			this.unitOfWork = unitOfWork;
			this.shipmentRepository = shipmentRepository;
		}

		public void Delete(int id)
		{
			var shipment = shipmentRepository.Get(id);
			if (shipment!=null)
			{
				shipmentRepository.Delete(shipment);
				unitOfWork.SaveChanges();
			}
		}

		public Shipment Get(int id)
		{
			return shipmentRepository.Get(id);
		}

		public IEnumerable<Shipment> GetAll()
		{
			return shipmentRepository.GetAll();
		}

		public void Insert(Shipment shipment)
		{
			shipmentRepository.Insert(shipment);
			unitOfWork.SaveChanges();
		}

		public void Update(Shipment shipment)
		{
			shipmentRepository.Update(shipment);
			unitOfWork.SaveChanges();
		}
	}

	public interface IShipmentService
	{
		void Insert(Shipment shipment);
		void Update(Shipment shipment);
		void Delete(int id);
		IEnumerable<Shipment> GetAll();
		Shipment Get(int id);
	}
}
