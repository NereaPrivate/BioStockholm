using BioStockholm.Web.Models.Pages;
using EPiServer.Core;

namespace BioStockholm.Web.Models.ViewModels
{
    public class NereaProductPageViewModel : PageViewModel<NereaProductPage>
    {
        public NereaProductPageViewModel(NereaProductPage currentPage) : base(currentPage)
        {
        }

        public string TrailerUrl { get; set; }
        public string TrailerImageUrl { get; set; }
        public ContentReference Image { get; set; }
        public string Heading { get; set; }
        public string Genre { get; set; }
        public string DurationTime { get; set; }
        public string Text { get; set; }
        public string Premiere { get; set; }
        public string AgeLimit { get; set; }
        public string OriginalLanguage { get; set; }
        public string Director { get; set; }
        public string YouTubeUrl { get; set; }

        //public NereaProductPageViewModel(NereaProductPage currentPage)
        //{
        //    TrailerUrl = currentPage.TrailerUrl;
        //    TrailerImageUrl = currentPage.TrailerImageUrl;
        //    Image = currentPage.Image;
        //    Heading = currentPage.Heading;
        //    Genre = currentPage.Genre;
        //    DurationTime = currentPage.DurationTime;
        //    Text = currentPage.Text;
        //    Premiere = currentPage.Premiere;
        //    AgeLimit = currentPage.AgeLimit;
        //    OriginalLanguage = currentPage.OrginalLanguage;
        //    Director = currentPage.Director;
        //}
    }
}