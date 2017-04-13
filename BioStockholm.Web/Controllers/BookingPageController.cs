using System.Web.Mvc;
using BioStockholm.Web.Models;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;

namespace BioStockholm.Web.Controllers
{
    public class BookingPageController : PageControllerBase<BookingPage>
    {
        [HttpGet]
        public ActionResult Index(Show show, NereaProductPageViewModel currentPage)
        {
            var model = new BookingPageViewModel(new BookingPage())
            {
                Show = show
            };

            return View("~/Views/BookingPage/Index.cshtml", model);
        }
    }
}