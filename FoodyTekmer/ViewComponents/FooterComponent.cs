using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.ViewComponents
{
    public class FooterComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
