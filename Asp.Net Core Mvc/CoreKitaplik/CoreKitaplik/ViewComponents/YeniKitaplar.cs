using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreKitaplik.Models;

namespace CoreKitaplik.ViewComponents
{
    public class YeniKitaplar : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var kitapListesi = new List<Kitaplar>()
            {
                new Kitaplar {Id=6,KitapAd="Outliers",Yazar="Malcolm Gladwell"},
                new Kitaplar {Id=7,KitapAd="Ezilenler",Yazar="Dostoyevski"},
                new Kitaplar {Id=8,KitapAd="Suç ve Ceza",Yazar="Victor Hugo"},
            };
            return View(kitapListesi);
        }
    }
}
