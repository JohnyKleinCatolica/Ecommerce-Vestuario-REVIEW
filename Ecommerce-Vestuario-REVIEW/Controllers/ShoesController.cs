using Ecommerce_Vestuario_REVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Vestuario_REVIEW.Controllers
{
    public class ShoesController : Controller
    {
        private ApplicationDbContext _context;

        public ShoesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Shoes
        public ActionResult Index()
        {
            IEnumerable<Shoes> shoes = _context.Shoes.ToList();

            return View(shoes);
        }
    }
}