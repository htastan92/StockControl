using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class StockService : IStockService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Stock> stockRepository;
		public StockService (IUnitOfWork unitOfWork,IRepository<Stock> stockRepository)
		{
			this.unitOfWork = unitOfWork;
			this.stockRepository = stockRepository;
		}

		public void Delete(int id)
		{
			var stock = stockRepository.Get(id);
			if (stock!=null)
			{
				stockRepository.Delete(stock);
				unitOfWork.SaveChanges();
			}
		}

		public Stock Get(int id)
		{
			return stockRepository.Get(id);
		}

		public IEnumerable<Stock> GetAll()
		{
			return stockRepository.GetAll();
		}

		public void Insert(Stock stock)
		{
			stockRepository.Insert(stock);
			unitOfWork.SaveChanges();
		}

		public void Update(Stock stock)
		{
			stockRepository.Update(stock);
			unitOfWork.SaveChanges();
		}
	}
	public interface IStockService
	{
		void Insert(Stock stock);
		void Update(Stock stock);
		void Delete(int id);
		IEnumerable<Stock> GetAll();
		Stock Get(int id);
	}
}
