using DataAccessLayer.Context;
using FoodyTekmerEntityLayer.Concreate;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Controllers
{
    public class CategoryController : Controller
    {
        FoodyContext context = new FoodyContext();
        public IActionResult Index()
        {
            var values = context.Categories.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory(Category category)
        {
            context.Categories.Add(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteCategory(int id)
        {
            Category category = context.Categories.Find(id);
            context.Categories.Remove(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            Category category = context.Categories.Find(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            context.Categories.Update(category);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}
