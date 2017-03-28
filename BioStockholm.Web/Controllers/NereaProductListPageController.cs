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
        public ActionResult Index(NereaProductListPage currentPage)
        {
            //var model = new NereaProductListPageViewModel(currentPage)
            //{
            //    Heading = currentPage.PageHeading,
            //    Preamble = currentPage.PagePreamble
            //};
            var model = PageViewModel.Create(currentPage);

            return View(model);
        }
    }
}