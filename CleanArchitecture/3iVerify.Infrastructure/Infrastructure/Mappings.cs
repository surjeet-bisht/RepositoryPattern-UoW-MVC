using CleanArchitecture.Data;
using CleanArchitecture.Infrastructure.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Infrastructure
{
	public class Mappings : Profile
	{
		public static Mapper MappingConfig()
		{
			var config = new MapperConfiguration(cfg =>
			{
				cfg.CreateMap<Supplier, SupplierModel>().ReverseMap();
			});
			return new Mapper(config);
		}
	}
}
