using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pharmacy.Service.Service;

namespace Pharmacy.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {

            Products ps = new Products();

            return View(ps.GetAllProducts());
        }
    }
}