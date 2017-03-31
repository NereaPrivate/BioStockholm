using System.Web.Mvc;
using BioStockholm.Web.Models.Pages;
using BioStockholm.Web.Models.ViewModels;

namespace BioStockholm.Web.Controllers
{
    public class NereaProductPageController : PageControllerBase<NereaProductPage>
    {
        public ActionResult Index(NereaProductPage currentPage)
        {
            var model = new NereaProductPageViewModel(currentPage)
            {
                YouTubeUrl = CreateTrailerUrl(currentPage)

            };

            return View(model);
        }

        private string CreateTrailerUrl(NereaProductPage currentPage)
        {
            return @"https://www.youtube.com/embed/" + currentPage.TrailerUrl;
        }
    }
}