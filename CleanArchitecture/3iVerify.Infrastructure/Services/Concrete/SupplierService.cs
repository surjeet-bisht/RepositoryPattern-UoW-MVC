using CleanArchitecture.Data;
using CleanArchitecture.Infrastructure.Models;
using CleanArchitecture.Infrastructure.Services.Interfaces;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Services
{
	public class SupplierService : ISupplierService
	{
		private readonly IUnitOfWork _unitOfWork;
		public IMapper _mapper;
        public SupplierService(IUnitOfWork unitofWork, IMapper mapper)
        {
            _unitOfWork = unitofWork;
			_mapper = mapper;
		}
        public SupplierModel SupplierDetail(int supplierID)
		{
			var result = _unitOfWork.SupplierRepository.GetById(x=>x.SupplierID ==  supplierID);
			return _mapper.Map<SupplierModel>(result);

		}

		public List<SupplierModel> SupplierList()
		{
			var result = _unitOfWork.SupplierRepository.GetAll(x => x.Active == true);
			return _mapper.Map<List<SupplierModel>>(result);
		}

		public string SupplierNameByID(int SupplierID)
		{
			return _unitOfWork.SupplierRepository.GetSupplierName(SupplierID);
		}
	}
}
