using CoreMvcProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Controllers
{
    public class MyPersonalController : Controller
    {
        Context context = new Context();
        [Authorize]
        public IActionResult Index()
        {
            var values = context.Personals.Include(x => x.Unit).ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewPersonal()
        {
            List<SelectListItem> values = (from x in context.Units.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UnitName,
                                               Value = x.UnitId.ToString()
                                           }).ToList();
            ViewBag.val = values;
            return View();
        }
        [HttpPost]
        public IActionResult NewPersonal(Personal personal)
        {
            var per = context.Units.Where(x => x.UnitId == personal.Unit.UnitId).FirstOrDefault();
            personal.Unit = per;
            context.Personals.Add(personal);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult RemovePersonal(int id)
        {
            var per = context.Personals.Find(id);
            context.Personals.Remove(per);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult PersonalGetir(int id)
        {
            List<SelectListItem> values = (from x in context.Units.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.UnitName,
                                               Value = x.UnitId.ToString()
                                           }).ToList();
            ViewBag.val = values;
            var perso = context.Personals.Find(id);
            return View("PersonalGetir",perso);
        }
        public IActionResult UpdatePersonal(Personal personal)
        {
            var pers = context.Personals.Find(personal.PersonalId);
            pers.PersonalFirstName = personal.PersonalFirstName;
            //per.PersonalLastName = personal.PersonalLastName;
            //per.PersonalCity = personal.PersonalCity;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

       



    }
}
