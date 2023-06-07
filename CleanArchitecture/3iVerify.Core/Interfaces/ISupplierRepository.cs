using CleanArchitecture.Data;

namespace CleanArchitecture.Core
{
	public interface ISupplierRepository : IGenericRepository<Supplier>
	{
		string GetSupplierName(int SupplierID);
	}
}
