using CleanArchitecture.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Core.Concrete
{
	public class SupplierRepository : GenericRepository<Supplier>, ISupplierRepository
	{
		public SupplierRepository(HACCPNowSQLDevEntities dbContext) : base(dbContext)
		{

		}

		public string GetSupplierName(int SupplierID)
		{
			return GetById(x => x.SupplierID == SupplierID).Supplier1;
		}
	}
}
