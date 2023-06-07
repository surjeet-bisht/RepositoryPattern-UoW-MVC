using CleanArchitecture.Infrastructure.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CleanArchitecture.Controllers
{
	public class HomeController : Controller
	{
		public ISupplierService _supplierService;
        public HomeController(ISupplierService supplierService)
        {
			_supplierService = supplierService;
		}
        public ActionResult Index()
		{
			var result = _supplierService.SupplierList();
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}
	}
}