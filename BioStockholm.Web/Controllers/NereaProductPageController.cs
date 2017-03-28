using System;
using System.Web.Mvc;
using EPiServer.Web.Mvc;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
using EPiServer.Core;
using EPiServer.Web.Routing;

namespace BioStockholm.Web.Controllers
{
    public class NereaProductPageController : PageControllerBase<NereaProductPage>
    {
        //private readonly UrlResolver _urlResolver;

        //public NereaProductPageController(UrlResolver urlResolver)
        //{
        //    _urlResolver = urlResolver;
        //}
        public ActionResult Index(NereaProductPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);
            //var model = new NereaProductPageViewModel()
            //{
            //    TrailerUrl = currentPage.TrailerUrl,
            //    TrailerImageUrl = currentPage.TrailerImageUrl
            //};
            //var model = new NereaProductPageViewModel(currentPage)
            //{
            //    Trailer = currentPage.Trailer,

            //};

            return View(model);
        }
    }
}