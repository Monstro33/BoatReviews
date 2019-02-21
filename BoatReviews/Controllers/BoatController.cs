using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoatReviews.Controllers
{
    public class BoatController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
 