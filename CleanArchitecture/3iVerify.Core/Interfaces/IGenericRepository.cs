using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core
{
	public interface IGenericRepository<T> where T : class
	{
		IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate);
		Boolean IsExists(Expression<Func<T, bool>> predicate);
		int RecordCount(Expression<Func<T, bool>> predicate);
		T GetById(Expression<Func<T, bool>> predicate);
		void Insert(T obj);
		void Update(T obj);
	}
}
