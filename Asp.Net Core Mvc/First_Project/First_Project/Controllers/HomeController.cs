using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using First_Project.Models;

namespace First_Project.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Index2()
        {
            return View();
        }
        public int Index3()
        {
            return 24;
        }
        public string Index4()
        {
            return "Merhaba Dünya";
        }
        public IActionResult Index5()
        {
            var kitaplar = new List<Kitap>()
            {
                new Kitap{ Id = 1, KitapAd = "80 günde devri alem", KitapYazar = "Jules Verne" },
                new Kitap { Id = 2, KitapAd = "Bilinmeyen bir kadının mektubu", KitapYazar = "zweig" },
                new Kitap { Id = 3, KitapAd = "Bir noel hikayesi", KitapYazar = "Charles Dickens" }
            };
            return View(kitaplar);
        }
        public IActionResult Index6()
        {
            ViewBag.deger1 = "Merhaba Core Dersleri Devam Ediyor.";
            ViewBag.deger2 = "Sizden bir ricam var";
            ViewBag.deger3 = "Eğitimler için teşekkürler";
            return View();
        }
        public  IActionResult Index7()
        {
            return View();
        }
        public IActionResult Index8()
        {
            return View();
        }
        public  IActionResult Index9()
        {
            return View();
        }
    }
}
