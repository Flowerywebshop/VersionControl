using Dnn.Bce.BouquetMakerModule2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dnn.Bce.BouquetMakerModule2.Controllers
{
    public class ApiSampleController : Controller
    {
        // GET: ApiSample
        public ActionResult Index()
        {
            // Default URL and API key
            var url = "http://20.234.113.211:8090/";
            var key = "1-16278226-9374-49b4-81a8-5a5bd6adfec0";

            // Pass URL and key to the view
            var viewModel = new ApiSampleViewModel
            {
                Url = url,
                Key = key
            };

            return View(viewModel);
        }
    }
}