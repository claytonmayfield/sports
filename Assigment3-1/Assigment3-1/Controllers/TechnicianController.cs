using Assigment3_1.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Assigment3_1.Controllers
{
    public class TechnicianController : Controller
    {

        private SportsProContext context { get; set; }

        public TechnicianController(SportsProContext ctx)
        {
            context = ctx;

        }
        public IActionResult List()
        {
            List<Technician> technicians = context.technicians.OrderBy(
                t => t.Name).ToList();
            return View(technicians);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Technician());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "edit";
            var technicians = context.technicians.Find(id);
            return View("AddEdit", technicians);
        }
        [HttpPost]

        public IActionResult Save(Technician tech)
        {
            if (ModelState.IsValid)
            {
                if (tech.TechnicianID == 0)
                {
                    context.technicians.Add(tech);
                }
                else
                {
                    context.technicians.Update(tech);
                }
                context.SaveChanges();
                return RedirectToAction("List");

            }
            else
            {
                if (tech.TechnicianID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "edit";
                }
                return View(tech);
            }


        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var tech = context.technicians.Find(id);
            return View(tech);
        }

        [HttpPost]
        public IActionResult Delete(Technician tech)
        {
            context.technicians.Remove(tech);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
   
    
}
