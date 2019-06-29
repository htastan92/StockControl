using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class CategoryService : ICategoryService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Category> categoryRepository;

		public CategoryService(IUnitOfWork unitOfWork, IRepository<Category> categoryRepository)
		{
			this.unitOfWork = unitOfWork;
			this.categoryRepository = categoryRepository;
		}

		public void Delete(int id)
		{
			var activity = categoryRepository.Get(id);
			if (activity != null)
			{
				categoryRepository.Delete(activity);
				unitOfWork.SaveChanges();
			}
		}	

		public Category Get(int id)
		{
			return categoryRepository.Get(id);
		}

		public IEnumerable<Category> GetAll()
		{
			return categoryRepository.GetAll();
		}	

		public void Insert(Category activity)
		{
			categoryRepository.Insert(activity);
			unitOfWork.SaveChanges();
		}

		public void Update(Category activity)
		{
			categoryRepository.Update(activity);
			unitOfWork.SaveChanges();
		}
	}

	public interface ICategoryService
	{
		void Insert(Category activity);
		void Update(Category activity);
		void Delete(int id);
		IEnumerable<Category> GetAll();
		Category Get(int id);	
		
	}
}
