using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using UploadFileInNestedGridPopupEditor.ViewModels;

namespace UploadFileInNestedGridPopupEditor.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Read([DataSourceRequest] DataSourceRequest request)
        {
            List<BidVM> bids = new List<BidVM>();
            for(int numOfBids = 0; numOfBids < 15; ++numOfBids)
            {
                bids.Add(new BidVM
                {
                    BidProfileId = numOfBids,
                    BidNumber = new Guid().ToString(),
                    BidTitle = "Some Title " + numOfBids,
                    BidBeginDate = DateTime.Now,
                    BidClosingDate = DateTime.Now.AddDays(15)
                });
            }
            return Json(bids.ToDataSourceResult(request));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
