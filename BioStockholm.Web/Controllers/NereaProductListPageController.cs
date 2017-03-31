using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace BioStockholm.Web.Controllers
{
    public class NereaProductListPageController : PageController<NereaProductListPage>
    {
        private readonly IContentRepository _contentRepository;

        public NereaProductListPageController(IContentRepository contentRepository)
        {
            _contentRepository = contentRepository;
        }

        public ActionResult Index(NereaProductListPage currentPage)
        {
            var model = new NereaProductListPageViewModel(currentPage)
            {
                //Heading = currentPage.PageHeading,
                //Preamble = currentPage.PagePreamble

                Products = GetProducts(currentPage)
            };
            
            return View(model);
        }

        private IEnumerable<NereaProductPage> GetProducts(NereaProductListPage currentPage)
        {
            return _contentRepository.GetChildren<NereaProductPage>(currentPage.ContentLink).ToList();
        }
    }
}