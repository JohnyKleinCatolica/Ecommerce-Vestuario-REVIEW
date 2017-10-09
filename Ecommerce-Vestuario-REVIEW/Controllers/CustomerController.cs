using Ecommerce_Vestuario_REVIEW.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using Ecommerce_Vestuario_REVIEW.Models;
using Ecommerce_Vestuario_REVIEW.ViewModels;

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

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipType.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipType = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost] // só será acessada com POST
        public ActionResult Save(Customer customer) // recebemos um cliente
        {
            // armazena o cliente em memória
            _context.Customers.Add(customer);
            // faz a persistência
            _context.SaveChanges();
            // Voltamos para a lista de clientes
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();

            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipType = _context.MembershipType.ToList()
            };

            return View("CustomerForm", viewModel);
        }
    }
}