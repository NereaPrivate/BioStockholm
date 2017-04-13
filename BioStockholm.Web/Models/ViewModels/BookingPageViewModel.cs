using BioStockholm.Web.Models.Pages;

namespace BioStockholm.Web.Models.ViewModels
{
    public class BookingPageViewModel : PageViewModel<BookingPage>
    {
    
        public BookingPageViewModel(BookingPage currentPage) : base(currentPage)
        {
        }

        public Show Show { get; set; }
    }
}