using FoodyTemkerBussinesLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace FoodyTekmer.ViewComponents
{
    public class ProductListComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetAllList();
            return View(values);
        }
    }
}
