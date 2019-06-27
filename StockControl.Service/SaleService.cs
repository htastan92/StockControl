using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class SaleService : ISaleService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Sale> saleRepository;

		public SaleService(IUnitOfWork unitOfWork,IRepository<Sale> saleRepository)
		{
			this.unitOfWork = unitOfWork;
			this.saleRepository = saleRepository;
		}

		public void Delete(int id)
		{
			var sale = saleRepository.Get(id);
			if (sale != null)
			{
				saleRepository.Delete(sale);
				unitOfWork.SaveChanges();
			}
		}

		public Sale Get(int id)
		{
			return saleRepository.Get(id);
		}

		public IEnumerable<Sale> GetAll()
		{
			return saleRepository.GetAll();
		}

		public void Insert(Sale sale)
		{
			saleRepository.Insert(sale);
			unitOfWork.SaveChanges();
		}

		public void Update(Sale sale)
		{
			saleRepository.Update(sale);
			unitOfWork.SaveChanges();
		}
	}
	public interface ISaleService
	{
		void Insert(Sale sale);
		void Update(Sale sale);
		void Delete(int id);
		IEnumerable<Sale> GetAll();
		Sale Get(int id);		
	}
}
