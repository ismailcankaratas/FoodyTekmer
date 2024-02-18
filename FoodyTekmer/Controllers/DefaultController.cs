using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title1 = "Ürünler";
            ViewBag.title2 = "Anasayfa";
            ViewBag.title3 = "Sayfalar";
            ViewBag.title4 = "Ürün Lİstesi";
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialPageHeader()
        {
            return PartialView();
        }
        public PartialViewResult ScriptComponentPartial()
        {
            return PartialView();
        }
        public PartialViewResult SpinnerPartial()
        {
            return PartialView();
        }
    }
}
