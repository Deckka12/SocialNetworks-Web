using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SocialNetworks.ViewModel.Account;
using System.Diagnostics;

namespace SocialNetworks.Controllers {
    public class HomeController : Controller {



        [Route("")]
        [Route("[controller]/[action]")]
        public IActionResult Index () {
            return View(new MainViewModel());
        }

        [Route("[action]")]
        public IActionResult Privacy () {
            return View();
        }


    }
}
