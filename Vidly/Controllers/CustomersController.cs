using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "João Silva"},
                new Customer { Id = 2, Name = "Pedro Soares" }
            };

            var viewModel = new CustomersViewModel
            {
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("clientes/detalhes/{id}")]
        public ActionResult Details(int id)
        {
            if (id == 1)
                return View(new Customer {Id = 1, Name = "João Silva"});

            if (id == 2)
                return View(new Customer { Id = 2, Name = "Pedro Soares" });

            return View();
        }
    }
}