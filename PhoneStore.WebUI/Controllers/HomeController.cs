using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PhoneStore.Domain.Concrete;
using PhoneStore.Domain.Abstract;
using PhoneStore.Models;
using PhoneStore.Domain.Entities;

namespace PhoneStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPhoneRepository _phoneRepository;
        private readonly IOrderRepository _orderRepository;

        public HomeController(IPhoneRepository phoneRepo, IOrderRepository orderRepo,
            ILogger<HomeController> logger)
        {
            _phoneRepository = phoneRepo;
            _orderRepository = orderRepo;
            _logger = logger;
        }
        [Route("Buy/{id:int?}")]
        [HttpGet]
        public IActionResult Buy(int? id)
        {
            if (id == null) return RedirectToAction("Index");
            ViewBag.PhoneId = id;
            return View();
        }
        [Route("Buy/{id:int?}")]

        [HttpPost]
        public string Buy(Order order)
        {
            _orderRepository.AddOrder(order);
            return "Спасибо, " + order.User + ", за покупку!";
        }
        [Route("")]
        [Route("Index")]
        public IActionResult Index()
        {
            return View(_phoneRepository.GetPhones());
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
