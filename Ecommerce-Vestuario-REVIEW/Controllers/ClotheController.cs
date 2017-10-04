using Ecommerce_Vestuario_REVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ecommerce_Vestuario_REVIEW.Controllers
{
    public class ClotheController : Controller
    {
        private ApplicationDbContext _context;

        public ClotheController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            IEnumerable<Clothe> clothes = _context.Clothes.ToList();
            return View(clothes);
        }
    }
}