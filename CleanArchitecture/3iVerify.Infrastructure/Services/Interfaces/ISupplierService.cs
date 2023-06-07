using CleanArchitecture.Infrastructure.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services.Interfaces
{
	public interface ISupplierService
	{
		List<SupplierModel> SupplierList();
		SupplierModel SupplierDetail(int supplierID);
		string SupplierNameByID(int SupplierID);
	}
}
