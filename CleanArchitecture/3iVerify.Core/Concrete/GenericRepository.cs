using CleanArchitecture.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Concrete
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		protected HACCPNowSQLDevEntities _dbContext;
		protected DbSet<T> dbSet;
		public GenericRepository(HACCPNowSQLDevEntities dbContext)
		{
			_dbContext = dbContext;
			dbSet = _dbContext.Set<T>();
		}
		public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Where(predicate);
		}
		public Boolean IsExists(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Any(predicate);
		}
		public int RecordCount(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Where(predicate).Count();
		}

		public T GetById(Expression<Func<T, bool>> predicate)
		{
			return dbSet.Where(predicate).FirstOrDefault();
		}
		public void Insert(T obj)
		{
			dbSet.Add(obj);
		}

		public void Update(T obj)
		{
			dbSet.Attach(obj);
			_dbContext.Entry(obj).State = EntityState.Modified;
		}
	}
}
