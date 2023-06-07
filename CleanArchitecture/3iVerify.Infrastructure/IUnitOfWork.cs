using CleanArchitecture.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
	public interface IUnitOfWork : IDisposable
	{
		ISupplierRepository SupplierRepository { get; }
		void Commit();

	}
}
