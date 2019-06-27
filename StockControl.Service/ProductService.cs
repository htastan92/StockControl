using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class ProductService : IProductService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Product> productRepository;

		public ProductService(IUnitOfWork unitOfWork, IRepository<Product> productRepository)
		{
			this.unitOfWork = unitOfWork;
			this.productRepository = productRepository;
		}


		public void Delete(int id)
		{
			var product = productRepository.Get(id);
			productRepository.Delete(product);
			unitOfWork.SaveChanges();
		}

		public Product Get(int id)
		{
			return productRepository.Get(id);
		}

		public IEnumerable<Product> GetAll()
		{
			return productRepository.GetAll();
		}
	

		public void Insert(Product product)
		{
			productRepository.Insert(product);
			unitOfWork.SaveChanges();
		}

		public void Update(Product product)
		{
			productRepository.Insert(product);
			unitOfWork.SaveChanges();
		}
	}

	public interface IProductService
	{
		void Insert(Product product);
		void Update(Product product);
		void Delete(int id);
		IEnumerable<Product> GetAll();
		Product Get(int id);
		
		
	}
}
