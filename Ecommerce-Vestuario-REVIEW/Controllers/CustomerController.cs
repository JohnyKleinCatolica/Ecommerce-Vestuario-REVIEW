using Ecommerce_Vestuario_REVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Ecommerce_Vestuario_REVIEW.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult Index()
        {
            IEnumerable<Customer> customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

		public ActionResult Details(int id)
		{
			IEnumerable<Customer> customers = _context.Customers.Include(c => c.MembershipType);
			var customer = customers.SingleOrDefault(m => m.Id == id);

			return View(customer);
		}
	}
}