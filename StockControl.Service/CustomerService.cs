using StockControl.Data;
using StockControl.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockControl.Service
{
	public class CustomerService : ICustomerService
	{
		private readonly IUnitOfWork unitOfWork;
		private readonly IRepository<Customer> customerRepository;

		public CustomerService(IUnitOfWork unitOfWork, IRepository<Customer> customerRepository)
		{
			this.unitOfWork = unitOfWork;
			this.customerRepository = customerRepository;
		}

		public void Delete(int id)
		{
			var customer = customerRepository.Get(id);
			if (customer != null)
			{
				customerRepository.Delete(customer);
				unitOfWork.SaveChanges();
			}
		}

		public Customer Get(int id)
		{
			return customerRepository.Get(id);
		}

		public IEnumerable<Customer> GetAll()
		{
			return customerRepository.GetAll();
		}

		public void Insert(Customer customer)
		{
			customerRepository.Insert(customer);
			unitOfWork.SaveChanges();
		}

		public void Update(Customer customer)
		{
			customerRepository.Update(customer);
			unitOfWork.SaveChanges();
		}

	}
	public interface ICustomerService
	{
		void Insert(Customer customer);
		void Update(Customer customer);
		void Delete(int id);
		IEnumerable<Customer> GetAll();
		Customer Get(int id);		
	}

}
