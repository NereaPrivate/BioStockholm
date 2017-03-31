using BioStockholm.Web.Models.Pages;
using EPiServer.Core;
using System.Collections.Generic;
using System.Linq;

namespace BioStockholm.Web.Models.ViewModels
{
    public class NereaStartPageViewModel : PageViewModel<NereaStartPage>
    {
        public NereaStartPageViewModel(NereaStartPage currentPage) : base(currentPage)
        {
        }

        public ContentArea MainContentArea { get; set; }

        public IEnumerable<NereaProductPage> Products { get; set; }

        public IEnumerable<NereaProductPage> LatestProducts(int value = 9)
        {
            if (Products != null && Products.Any())
            {
                return Products.Take(value);
            }

            return Products;
        }
    }
}