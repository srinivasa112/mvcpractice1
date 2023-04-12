using EfDBfirstApproachExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfDBfirstApproachExample.Controllers
{
	public class ProductsController : Controller
	{
		// GET: Products
		public ActionResult Index()
		{
			{
				CompanyDbContext db = new CompanyDbContext();
				List<Product> products = db.Products.ToList();
				return View(products);
			}
		}
	}
}
