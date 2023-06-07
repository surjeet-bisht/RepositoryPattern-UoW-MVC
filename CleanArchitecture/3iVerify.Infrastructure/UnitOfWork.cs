using CleanArchitecture.Core;
using CleanArchitecture.Core.Concrete;
using CleanArchitecture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
namespace CleanArchitecture.Infrastructure
{
	public class UnitOfWork : IUnitOfWork
	{
		private HACCPNowSQLDevEntities _dbContext;
		private ISupplierRepository _supplierRepository;
		public UnitOfWork()
		{
			_dbContext = new HACCPNowSQLDevEntities("HACCPNowSQLDevEntities");
		}
		public ISupplierRepository SupplierRepository
		{
			get
			{
				if (_supplierRepository == null)
				{
					_supplierRepository = new SupplierRepository(_dbContext);
				}
				return _supplierRepository;
			}
		}

		public void Commit()
		{
			_dbContext.SaveChanges();
		}

		private bool disposed = false;

		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				if (disposing)
				{
					_dbContext.Dispose();
				}
			}
			this.disposed = true;
		}

		public void Dispose()
		{
			Dispose(true);
			GC.SuppressFinalize(this);
		}
	}
}
