using System.Web.Mvc;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;
using EPiServer.Web;
using EPiServer.Web.Mvc;

namespace BioStockholm.Web.Controllers
{
    public class NereaStartPageController : PageControllerBase<NereaStartPage>
    {
        public ActionResult Index(NereaStartPage currentPage)
        {
            var model = PageViewModel.Create(currentPage);

            //if (SiteDefinition.Current.StartPage.CompareToIgnoreWorkID(currentPage.ContentLink)) // Check if it is the StartPage or just a page of the StartPage type.
            //{
            //    //Connect the view models logotype property to the start page's to make it editable
            //    var editHints = ViewData.GetEditHints<PageViewModel<NereaStartPage>, NereaStartPage>();
            //    editHints.AddConnection(m => m.Layout.Logotype, p => p.SiteLogotype);
            //    editHints.AddConnection(m => m.Layout.ProductPages, p => p.ProductPageLinks);
            //    editHints.AddConnection(m => m.Layout.CompanyInformationPages, p => p.CompanyInformationPageLinks);
            //    editHints.AddConnection(m => m.Layout.NewsPages, p => p.NewsPageLinks);
            //    editHints.AddConnection(m => m.Layout.CustomerZonePages, p => p.CustomerZonePageLinks);
            //}

            return View(model);
        }

    }
}
