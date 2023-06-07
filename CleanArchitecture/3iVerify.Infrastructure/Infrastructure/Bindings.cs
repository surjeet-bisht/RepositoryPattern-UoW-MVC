using CleanArchitecture.Infrastructure.Services;
using CleanArchitecture.Infrastructure.Services.Interfaces;
using AutoMapper;
using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Infrastructure
{
	public class Bindings
	{
		public void AddBindings(IKernel ninjectKernel)
		{
			ninjectKernel.Bind<ISupplierService>().To<SupplierService>();
			ninjectKernel.Bind<IUnitOfWork>().To<UnitOfWork>();
			ninjectKernel.Bind<IMapper>()
			.ToMethod(context =>
			{
				var config = new MapperConfiguration(cfg =>
				{
					cfg.AddProfile<Mappings>();
					// tell automapper to use ninject when creating value converters and resolvers
					cfg.ConstructServicesUsing(t => ninjectKernel.Get(t));
				});
				return config.CreateMapper();
			}).InSingletonScope();
		}
	}
}
