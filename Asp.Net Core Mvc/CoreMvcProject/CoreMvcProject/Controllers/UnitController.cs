using CoreMvcProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMvcProject.Controllers
{
    public class UnitController : Controller
    {
        Context context = new Context();
        public IActionResult Index()
        {
            var values = context.Units.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddUnit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddUnit(Unit unit)
        {
            context.Units.Add(unit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult RemoveUnit(int id)
        {
            var unit = context.Units.Find(id);
            context.Units.Remove(unit);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetUnit(int id)
        {
            var unit = context.Units.Find(id);
            return View("GetUnit", unit);
        }
        public IActionResult UpdateUnit(Unit unit)
        {
            var un = context.Units.Find(unit.UnitId);
            un.UnitName = unit.UnitName;
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult UnitDetail(int id)
        {
            var values = context.Personals.Where(x => x.UnitId == id).ToList();
            var untname = context.Units.Where(x => x.UnitId == id).Select(y => y.UnitName).FirstOrDefault();
            ViewBag.unname = untname;
            return View(values);
        }
    }
}
