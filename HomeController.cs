using BasamakSayisiWebApplication.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using System.Diagnostics;

namespace BasamakSayisiWebApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(BasamakSayisi basamakSayisi)
        {
            int basamak_sayisi = 0;
            var sayi_ = basamakSayisi.Sayi;
            var message = string.Empty;
            if (sayi_ >= 100)
            {

                message = "0-99.999 arasında bir sayı değeri giriniz";
            }
            else 
            {
                while (sayi_ > 0 && sayi_ < 99.999)
                {
                    sayi_ = sayi_ / 10;
                    basamak_sayisi++;
                }
                message="Girdiginiz sayi " + basamak_sayisi + " basamaklıdır.";

            }
            ViewBag.Message = message;
            return View("basamakSayisi");
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