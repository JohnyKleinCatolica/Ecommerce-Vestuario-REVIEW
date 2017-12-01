using Ecommerce_Vestuario_REVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Vestuario_REVIEW.Controllers
{
    public class AccessoriesController : Controller
    {
        private ApplicationDbContext _context;

        public AccessoriesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Accessories
        public ActionResult Index()
        {
            IEnumerable<Accessories> accessories = _context.Accessories.ToList();
            return View(accessories);
        }
    }
}