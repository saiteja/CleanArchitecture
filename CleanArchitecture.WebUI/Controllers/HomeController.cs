using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.WebUI.Models;
using CleanArchitecture.Application.Dealer;

namespace CleanArchitecture.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public readonly IGetDealerDetails _getDealerDetails;

        public HomeController(IGetDealerDetails getDealerDetails)
        {
            _getDealerDetails = getDealerDetails;
        }

        public IActionResult Index()
        {
            List<DealerResponseModel> dealers = _getDealerDetails.Execute().ToList();
            return View(dealers);
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