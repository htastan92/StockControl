using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using StockControl.Data;
using StockControl.Model;

namespace StockControl.Data
{
	public class Repository<T> : IRepository<T> where T : BaseEntity
	{
		private readonly ApplicationDbContext db;
		private readonly DbSet<T> entities;
		public Repository(ApplicationDbContext context)
		{
			this.db = context;
			this.entities = context.Set<T>();
		}
		public void Delete(T entity)
		{
			entities.Remove(entity);
		}

		public T Get(int id)
		{
			return entities.FirstOrDefault(x => x.Id == id);
		}

		public T Get(Expression<Func<T, bool>> where)
		{
			return entities.Where(where).FirstOrDefault();
		}

		public IEnumerable<T> GetAll()
		{
			return entities.ToList();
		}

		public IEnumerable<T> GetAll(Expression<Func<T, bool>> where)
		{
			return entities.Where(where).ToList();
		}

		public void Insert(T entity)
		{
			entities.Add(entity);
		}

		public void Update(T entity)
		{
			db.Entry<T>(entity).State = EntityState.Modified;
		}
	}
	public interface IRepository<T> where T : BaseEntity
	{
		void Insert(T entity);
		void Update(T entity);
		void Delete(T entity);
		T Get(int id);
		IEnumerable<T> GetAll();
		T Get(Expression<Func<T, bool>> where);
		IEnumerable<T> GetAll(Expression<Func<T, bool>> where);
	}
}