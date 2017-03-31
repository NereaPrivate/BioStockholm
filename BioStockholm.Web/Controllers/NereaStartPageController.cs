using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
using EPiServer;

namespace BioStockholm.Web.Controllers
{
    public class NereaStartPageController : PageControllerBase<NereaStartPage>
    {
        private readonly IContentRepository _contentRepository;

        public NereaStartPageController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public ActionResult Index(NereaStartPage currentPage)
        {
            var model = new NereaStartPageViewModel(currentPage)
            {
                Products = GetProducts(currentPage)
            };

            return View(model);
        }

        public IEnumerable<NereaProductPage> GetProducts(NereaStartPage currentPage)
        {
            var products = new List<NereaProductPage>();

            if (currentPage.ProductPage != null)
            {
                var listPage = _contentRepository.Get<NereaProductListPage>(currentPage.ProductPage);
                products = _contentRepository.GetChildren<NereaProductPage>(listPage.ContentLink).ToList();
            }

            return products;
        }
    }
}