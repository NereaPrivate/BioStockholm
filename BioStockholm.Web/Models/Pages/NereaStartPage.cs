using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace BioStockholm.Web.Models.Pages
{
    [ContentType(
        GUID = "1148a30e-b8db-446c-a82f-5aca5b7fb64f",
         GroupName = Global.GroupNames.Specialized)]
    [SiteImageUrl]
    [AvailableContentTypes(
        Availability.Specific,
        Include = new[] { typeof(NereaProductListPage)/*, typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage), typeof(ContentFolder)*/ })]// Pages we can create under the start page...
        //ExcludeOn = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage) })]
    public class NereaStartPage : SitePageData
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */

        [CultureSpecific]
        [Display(
                 GroupName = SystemTabNames.Content,
                 Order = 1)]
        public virtual ContentArea MainContentArea { get; set; }
    }
}