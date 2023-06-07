using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Models
{
	public class SupplierModel
	{
		public int SupplierID { get; set; }
		public string Supplier1 { get; set; }
		public string SupplierRef { get; set; }
		public Nullable<int> SupplierTypeID { get; set; }
		public Nullable<int> SupplierGroupID { get; set; }
		public string SiteName { get; set; }
		public bool AddressOptional { get; set; }
		public string Address1 { get; set; }
		public string Address2 { get; set; }
		public string Address3 { get; set; }
		public string Address4 { get; set; }
		public string Address5 { get; set; }
		public Nullable<int> CountryID { get; set; }
	}
}
