using Assigment3_1.Models;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;


namespace Assigment3_1.Controllers
{
    public class ProductController : Controller
    {
        private SportsProContext context { get; set; }


        public ProductController(SportsProContext ctx)
        {
            context = ctx;

        }

        public IActionResult List()
        {
            List<Product> products = context.Products.OrderBy(
                p => p.ReleaseDate).ToList();
            return View(products);
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            return View("AddEdit", new Product());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "edit";
            var products = context.Products.Find(id);
            return View("AddEdit", products);
        }

        [HttpPost]

        public IActionResult Save(Product product)
        {
            if (ModelState.IsValid)
            {
                if (product.ProductID == 0)
                {
                    context.Products.Add(product);
                }
                else
                {
                    context.Products.Update(product);
                }
                context.SaveChanges();
                return RedirectToAction("List");

            }
            else
            {
                if (product.ProductID == 0)
                {
                    ViewBag.Action = "Add";
                }
                else
                {
                    ViewBag.Action = "edit";
                }
                return View(product);
            }


        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = context.Products.Find(id);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(Product product)
        {
            context.Products.Remove(product);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}