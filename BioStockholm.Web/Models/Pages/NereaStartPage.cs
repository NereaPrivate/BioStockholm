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
         Include = new[]{typeof(NereaProductListPage)/*, typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage), typeof(ContentFolder)*/})] // Pages we can create under the start page...
        //ExcludeOn = new[] { typeof(ContainerPage), typeof(ProductPage), typeof(StandardPage), typeof(ISearchPage), typeof(LandingPage) })]
    public class NereaStartPage : SitePageData
    {
        [CultureSpecific]
        [Display(
             GroupName = SystemTabNames.Content,
             Order = 1)]
        public virtual ContentArea MainContentArea { get; set; }

        [CultureSpecific]
        [Display(
             GroupName = SystemTabNames.Content,
             Order = 10)]
        public virtual ContentReference ProductPage { get; set; }

        public override void SetDefaultValues(ContentType contentType)
        {
            base.SetDefaultValues(contentType);
            VisibleInMenu = false;
        }
    }
}